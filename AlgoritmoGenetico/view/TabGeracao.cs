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
            this.subTabGeracaoAtual.Text = String.Format("[Geração {0}]", this.tabControl.TabCount + 1);

            this.tabControl.Controls.Add(this.subTabGeracaoAtual);
        }

        public void PopularGridGeracaoAtual(Geracao g)
        {
            SubTabGeracao tab = this.tabControl.TabPages[tabControl.TabCount -1] as SubTabGeracao;
            tab.CarregarDados(g);
        }

        public void DesabilitarBotaoAvancar()
        {
            this.btAvancar.Enabled = false;
            this.btMutacoes.Enabled = true;
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            if (this.AvancarGeracaoEvent != null)
            {
                this.AvancarGeracaoEvent(this, null);
            }
        }

        /// <summary>
        /// Overload da função padrão que desenha a tab
        /// </summary>
        private void OnDrawItem(object sender, DrawItemEventArgs e)
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
