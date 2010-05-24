using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoritmoGenetico.model;
using AlgoritmoGenetico.model.core;
using AlgoritmoGenetico.model.delegates;
using AlgoritmoGenetico.model.engine;

namespace AlgoritmoGenetico.view
{
    public partial class TabGeracao : UserControl
    {

        private SubTabGeracao subTabGeracaoAtual;
        private event TabGeracaoAvancarGeracaoHandler AvancarGeracaoEvent;

        public TabGeracao(TelaPrincipal principal)
        {
            InitializeComponent();

            //ao clicar no botão 'Avançar 4 gerações' chama a função 'AvancarGeracao' da tela principal
            this.AvancarGeracaoEvent += new TabGeracaoAvancarGeracaoHandler(principal.AvancarGeracao);
            this.AdicionarGeracao();
        }

        public void AdicionarGeracao(){

            this.subTabGeracaoAtual = new SubTabGeracao();
            this.tabControl.Controls.Add(this.subTabGeracaoAtual);
            this.tabControl.SelectedTab = this.subTabGeracaoAtual;
        }

        /// <summary>
        /// Carrega os dados no grid de uma geração específica
        /// </summary>
        /// <param name="qtdGeracoes">Quantidade de gerações que já existem no programa</param>
        /// <param name="geracao">Nova geração</param>
        public void PopularGridGeracaoAtual(int qtdGeracoes, Geracao geracao)
        {
            this.subTabGeracaoAtual.Text = String.Format("[Geração {0}]", qtdGeracoes);
            SubTabGeracao tab = this.tabControl.TabPages[tabControl.TabCount -1] as SubTabGeracao;
            tab.CarregarDados(geracao);
        }

        /// <summary>
        /// Escreve no label correspondente da subtab o valor da variação da aptidão
        /// </summary>
        /// <param name="variacao">Variação relativa da aptidão</param>
        public void PopularVariacaoRelativa(double variacao)
        {
            this.lblDifRelativaValor.Text = variacao.ToString();
        }

        /// <summary>
        /// Destaca a variação da aptidão, pois é a última, configurando o label na cor vermelha
        /// </summary>
        public void DestacarVariacaoRelativaFinal()
        {
            this.lblDifRelativaValor.ForeColor = Color.Red;
        }

        /// <summary>
        /// Desabilita o botão 'Avançar gerações' e habilita o botão 'Ressaltar Mutações',
        /// pois é possível avançar gerações apenas uma vez por subtab
        /// </summary>
        public void DesabilitarBotaoAvancar()
        {
            this.btAvancar.Enabled = false;
            this.btMutacoes.Enabled = true;
        }

        #region Eventos de clicks na subtab que agrupa 5 gerações

        private void btAvancar_Click(object sender, EventArgs e)
        {
            if (this.AvancarGeracaoEvent != null)
            {
                this.AvancarGeracaoEvent(this, null);
            }
        }

        private void btMutacoes_Click(object sender, EventArgs e)
        {
            this.btMutacoes.Enabled = false;

            SubTabGeracao tab;
            Cromossomo c;

            TabPage tabMutacao = null;

            for (int i = 0; i < this.tabControl.TabCount; i++)
            {
                tab = this.tabControl.Controls[i] as SubTabGeracao;

                for (int j = 0; j < tab.Geracao.Populacao.Count; j++)
                {
                    c = tab.Geracao.Populacao[j];

                    if (c.GenesMutados != null)
                    {
                        if (tabMutacao == null)
                        {
                            tabMutacao = tab;
                        }

                        tab.panel.AlterarCorLinha(j);
                    }
                }
            }

            if (tabMutacao != null)
            {
                this.tabControl.SelectedTab = tabMutacao;
            }

        }

        #endregion

        /// <summary>
        /// Overload da função padrão que desenha a tab
        /// </summary>
        private void RenderizarTab(object sender, DrawItemEventArgs e)
        {

            Font fntTab;
            Brush bshBack = Brushes.DarkBlue;
            Brush bshFore= Brushes.White;

            if (e.Index == this.tabControl.SelectedIndex)
            {
                fntTab = new Font(e.Font, FontStyle.Bold);
            }
            else
            {
                fntTab = e.Font;
                bshBack = Brushes.White;
                bshFore = Brushes.DarkBlue;
            }

            string tabName = this.tabControl.TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat();
            e.Graphics.FillRectangle(bshBack, e.Bounds);
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);
        }
    }
}
