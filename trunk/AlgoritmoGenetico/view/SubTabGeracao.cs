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
    public partial class SubTabGeracao : TabPage
    {

        public PanelGeracao panel;

        public SubTabGeracao()
        {
            this.panel = new PanelGeracao();
            this.panel.Dock = DockStyle.Fill;

            this.Controls.Add(this.panel);
        }

        public void CarregarDados(IList<Cromossomo> dados)
        {
            this.panel.Grid.DataSource = dados;
        }
    }
}
