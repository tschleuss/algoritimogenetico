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

namespace AlgoritmoGenetico
{
    public partial class TelaPrincipal : Form
    {

        private MatrizDistancias md;
        private Populacao p;

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
            
            TabGeracao tabGeracao = new TabGeracao();
            tabGeracao.Dock = DockStyle.Fill;
            page.Controls.Add(tabGeracao);

            tabGeracao.PopularGridGeracaoAtual(this.p.GeracaoAtual.Populacao);

            this.tabControlPrincipal.Controls.Add(page);
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
            this.p = new Populacao(md);
            this.p.GerarPopulacao();

            
            Console.WriteLine("Circuitos gerados randomicamente:");
            Console.WriteLine(p.ToString());
           
        }

        private void CalcularAptidao()
        {
            Aptidao ap = new Aptidao(this.md);
            ap.CalcularAptidaoBruta(this.p.GeracaoAtual.Populacao);
            ap.CalcularAptidaoPopulacional(this.p.GeracaoAtual);

            //após calcular a aptidaão bruta, atualiza a lista atual, ordenando pela aptidão bruta calculada
            this.p.AtualizarPopulacaoGeracaoAtual();

            
            Console.WriteLine("Circuitos ordenados por aptidao:");
            Console.WriteLine(p.ToString());
             
        }

        private void CalcularProbabilidade()
        {
            ProbabilidadeSelecao probab = new ProbabilidadeSelecao();
            probab.CalcularProbabilidade(this.p.GeracaoAtual);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
