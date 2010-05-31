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

            this.AdicionarTabGeracao(true);

            this.CalcularVariacaoRelativaGeracaoAtual();
        }

        /// <summary>
        /// Carrega a matriz de distâncias que será utilizada em várias classes do programa
        /// </summary>
        private void CarregarMatriz()
        {
            this.md = new MatrizDistancias();
            md.CarregarMatriz();

            //Console.WriteLine("Matriz de distancias:");
            //Console.WriteLine(md.ToString());
        }

        /// <summary>
        /// Inicia a primeira geração do programa
        /// </summary>
        private void IniciarPopulacao()
        {
            this.populacao = new Populacao(md);
            this.populacao.GerarPrimeiraGeracao();

            //Console.WriteLine("Circuitos gerados randomicamente:");
            //Console.WriteLine(populacao.ToString());
        }

        #region Cálculos realizados nas gerações

        private void CalcularAptidao()
        {
            Aptidao ap = new Aptidao(this.md);
            ap.CalcularAptidaoBruta(this.populacao.GeracaoAtual.Populacao);
            ap.CalcularAptidaoPopulacional(this.populacao.GeracaoAtual);

            //após calcular a aptidaão bruta, atualiza a lista atual, ordenando pela aptidão bruta calculada
            this.populacao.OrdenarCircuitosGeracaoAtual();

            //Console.WriteLine("Circuitos ordenados por aptidao:");
            //Console.WriteLine(populacao.ToString());
        }

        private void CalcularProbabilidade()
        {
            ProbabilidadeSelecao probab = new ProbabilidadeSelecao();
            probab.CalcularProbabilidade(this.populacao.GeracaoAtual);
        }

        private void GerarMutacoes()
        {
            MutacaoGenetica mutacao = new MutacaoGenetica(this.populacao.GeracaoAtual);
            mutacao.GerarMutacoes();
        }

        private void CalcularVariacaoRelativaGeracaoAtual(){
             
            VariacaoRelativa variacao = new VariacaoRelativa(this);
            
            int indiceGeracaoAtual = this.populacao.GeracaoAtual.ID -1;
            double aptidaoMediaPassada;
            double aptidaoMediaAtual = this.populacao.GeracaoAtual.AptidaoPopMedia;

            if (indiceGeracaoAtual != 0)
            {
                Geracao geracaoComparacao = this.populacao.ListaGeracoes[indiceGeracaoAtual - 5];
                aptidaoMediaPassada = geracaoComparacao.AptidaoPopMedia;
            }
            else
            {
                aptidaoMediaPassada = 0;
            }

            //calcula a variação
            double variacaoRelativa = variacao.CalcularDiferencaRelativa(aptidaoMediaAtual, aptidaoMediaPassada);

            //escreve no label
            this.tabGeracaoAtual.PopularVariacaoRelativa(variacaoRelativa);
        }

        #endregion

        #region Avanço de geração

        /// <summary>
        /// Adiciona a tab que agrupa 5 grids de gerações
        /// </summary>
        /// <param name="populaGrid">Indica se deve incluir a tab e popular a primeira geração dela</param>
        public void AdicionarTabGeracao(bool populaGrid)
        {
            int inicial = (this.tabControlPrincipal.TabCount * 5) + 1;
            int final = inicial + 4;

            TabPage page = new TabPage();
            page.Text = String.Format("Gerações [{0} - {1}]", inicial, final);

            this.tabGeracaoAtual = new TabGeracao(this);
            this.tabGeracaoAtual.Dock = DockStyle.Fill;
            page.Controls.Add(this.tabGeracaoAtual);

            this.tabControlPrincipal.Controls.Add(page);

            if (populaGrid)
            {
                this.PopularGridGeracalAtual();
            }

            this.tabControlPrincipal.SelectedTab = page;
        }


        private void PopularGridGeracalAtual()
        {
            this.tabGeracaoAtual.PopularGridGeracaoAtual(this.populacao.ListaGeracoes.Count, this.populacao.GeracaoAtual);
        }

        public void AvancarGeracao(object sender, EventArgs e)
        {
            this.AvancarGeracao(4);
        }

        private void btAvancarGeracoes_Click(object sender, EventArgs e)
        {
            this.btAvancarGeracoes.Enabled = false;
            this.AdicionarTabGeracao(false);
            this.AvancarGeracao(1);
            this.CalcularVariacaoRelativaGeracaoAtual();
        }

        public void AvancarGeracao(int qtdGeracoes)
        {
            for (int i = 1; i <= qtdGeracoes; i++)
            {

                Selecao selecao = new Selecao(this.populacao.GeracaoAtual);
                selecao.SelecionarPais();

                Geracao novaGeracao = new Geracao();
                this.populacao.AdicionarGeracao(novaGeracao);

                CrossOver crossOver = new CrossOver(this.populacao, novaGeracao, selecao.ListaPais);
                crossOver.CruzarPais();

                //cálculos da geração atual
                this.CalcularAptidao();
                this.CalcularProbabilidade();
                this.GerarMutacoes();

                //quando estiver abrindo uma nova aba que agrupa 5 gerações, não precisa adicionar a tab manualmente
                if (qtdGeracoes > 1)
                {
                    this.tabGeracaoAtual.AdicionarGeracao();
                }

                this.PopularGridGeracalAtual();
            }

            lblRodape.Text = String.Format("Evolução concluída. Geração atual: {0}", this.populacao.GeracaoAtual.ID);

            if (qtdGeracoes > 1)
            {
                this.tabGeracaoAtual.DesabilitarBotaoAvancar();
                this.btAvancarGeracoes.Enabled = true;
            }
        }

        #endregion

        /// <summary>
        /// Finaliza o processamento do programa
        /// </summary>
        public void PararEvolucao(object sender, EventArgs e)
        {
            this.tabGeracaoAtual.DesabilitarBotaoAvancar();
            this.tabGeracaoAtual.DestacarVariacaoRelativaFinal();

            this.separador4.Visible = true;
            this.btExibirResultado.Visible = true;
        }

        #region Eventos de clicks nos botões da tela principal

        /// <summary>
        /// Visualizar o gráfico de evolução da aptidão
        /// </summary>
        private void btVisualizarGrafico_Click(object sender, EventArgs e)
        {

            IList<double> listaAptidao = new List<double>();

            foreach(Geracao g in this.populacao.ListaGeracoes){
                listaAptidao.Add(g.AptidaoPopMedia);
            }

            RelatorioAptidao relatorioAptidao = new RelatorioAptidao(listaAptidao);
            relatorioAptidao.ShowDialog();
        }

        /// <summary>
        /// Exibir o resultado final do processamento
        /// </summary>
        private void btExibirResultado_Click(object sender, EventArgs e)
        {
            ResultadoFinal resultado = new ResultadoFinal(this.populacao.MenorCircuito);
            resultado.ShowDialog();
        }

        /// <summary>
        /// Reiniciar o programa
        /// </summary>
        private void btReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Exibir a tela com a matriz de distâncias
        /// </summary>
        private void btExibirMatriz_Click(object sender, EventArgs e)
        {
            TelaMatrizDistancias telaMatriz = new TelaMatrizDistancias(this.md);
            telaMatriz.ShowDialog();
        }

        #endregion
    }
}
