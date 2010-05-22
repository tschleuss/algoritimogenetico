using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoritmoGenetico.model.core;
using AlgoritmoGenetico.model.engine;
using AlgoritmoGenetico.view;
using AlgoritmoGenetico.model.delegates;
using AlgoritmoGenetico.model;
using System.Threading;

namespace AlgoritmoGenetico
{
    public partial class TelaPrincipal : Form
    {
        private MatrizDistancias md;
        private Populacao populacao;
        private TabGeracao tabGeracaoAtual;

        public TelaPrincipal()
        {
            this.InitializeComponent();

            this.CarregarMatriz();
            this.IniciarPopulacao();

            this.CalcularAptidao();
            this.CalcularProbabilidade();

            this.AdicionarTabGeracao();
        }

        public void AdicionarTabGeracao()
        {
            int inicial = (this.tabControlPrincipal.TabCount * 5) + 1;
            int final = inicial + 4;

            TabPage page = new TabPage();
            page.Text = String.Format("Gerações [{0} - {1}]", inicial, final);

            this.tabGeracaoAtual = new TabGeracao(this);
            this.tabGeracaoAtual.Dock = DockStyle.Fill;
            page.Controls.Add(this.tabGeracaoAtual);

            this.tabControlPrincipal.Controls.Add(page);

            this.PopularGridGeracalAtual();
        }

        private void PopularGridGeracalAtual()
        {
            this.tabGeracaoAtual.PopularGridGeracaoAtual(this.populacao.GeracaoAtual);
        }

        private void CarregarMatriz()
        {
            this.md = new MatrizDistancias();
            md.CarregarMatriz();

            Console.WriteLine("Matriz de distancias:");
            Console.WriteLine(md.ToString());
        }

        private void IniciarPopulacao()
        {
            this.populacao = new Populacao(md);
            this.populacao.GerarPrimeiraGeracao();

            Console.WriteLine("Circuitos gerados randomicamente:");
            Console.WriteLine(populacao.ToString());
           
        }

        private void CalcularAptidao()
        {
            Aptidao ap = new Aptidao(this.md);
            ap.CalcularAptidaoBruta(this.populacao.GeracaoAtual.Populacao);
            ap.CalcularAptidaoPopulacional(this.populacao.GeracaoAtual);

            //após calcular a aptidaão bruta, atualiza a lista atual, ordenando pela aptidão bruta calculada
            this.populacao.AtualizarPopulacaoGeracaoAtual();

            
            Console.WriteLine("Circuitos ordenados por aptidao:");
            Console.WriteLine(populacao.ToString());
        }

        private void CalcularProbabilidade()
        {
            ProbabilidadeSelecao probab = new ProbabilidadeSelecao();
            probab.CalcularProbabilidade(this.populacao.GeracaoAtual);
        }

        public void AvancarGeracao(object sender, EventArgs e)
        {

            lblRodape.Text = "Avançando 4 gerações...";

            //avança 4 gerações
            for (int i = 1; i <= 4; i++)
            {
                Selecao selecao = new Selecao(this.populacao.GeracaoAtual);
                selecao.SelecionarPais();

                Geracao novaGeracao = new Geracao();
                this.populacao.AdicionarGeracao(novaGeracao);

                CrossOver crossOver = new CrossOver(populacao, novaGeracao, selecao.ListaPais);
                crossOver.CruzarPais();

                //cálculos da geração atual
                this.CalcularAptidao();
                this.CalcularProbabilidade();

                this.tabGeracaoAtual.AdicionarGeracao();
                this.PopularGridGeracalAtual();
            }
           
            lblRodape.Text = String.Format("Evolução concluída. Geração atual:{0}", this.populacao.GeracaoAtual.ID);

            this.tabGeracaoAtual.DesabilitarBotaoAvancar();
        }

        private void btVisualizarGrafico_Click(object sender, EventArgs e)
        {

            IList<double> listaAptidao = new List<double>();

            foreach(Geracao g in this.populacao.ListaGeracoes){
                listaAptidao.Add(g.AptidaoPopulacional);
            }

            RelatorioAptidao relatorioAptidao = new RelatorioAptidao(listaAptidao);
            relatorioAptidao.ShowDialog();
        }
    }
}
