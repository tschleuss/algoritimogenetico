using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoritmoGenetico.model;

namespace AlgoritmoGenetico.view
{
    public partial class TabGeracao : UserControl
    {

        public TabGeracao()
        {
            InitializeComponent();

            this.AdicionarGeracao();
        }

        public void AdicionarGeracao(){

            SubTabGeracao tabPage = new SubTabGeracao();
            tabPage.Text = String.Format("[Geração {0}]", this.tabControl.TabCount+1);

            this.tabControl.Controls.Add(tabPage);
        }

        public void PopularGridGeracaoAtual(IList<Cromossomo> dados)
        {
            SubTabGeracao tab = this.tabControl.TabPages[tabControl.TabCount -1] as SubTabGeracao;
            tab.CarregarDados(dados);
        }
    }
}
