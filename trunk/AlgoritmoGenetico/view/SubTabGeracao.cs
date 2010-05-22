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

        public void CarregarDados(Geracao g)
        {
            this.panel.Grid.DataSource = g.Populacao;
            this.panel.LblAptidaoPopulacionalValor.Text = g.AptidaoPopulacional.ToString();
        }
    }
}
