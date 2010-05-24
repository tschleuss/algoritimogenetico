using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlgoritmoGenetico.view
{
    public partial class PanelGeracao : UserControl
    {
        private DataGridViewCellStyle estiloLinhaMutacao;

        public PanelGeracao()
        {
            InitializeComponent();

            this.estiloLinhaMutacao = new DataGridViewCellStyle();
            this.estiloLinhaMutacao.BackColor = Color.GreenYellow;
            this.estiloLinhaMutacao.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Altera a cor de uma linha do grid, para ressaltar uma mutação genética
        /// </summary>
        /// <param name="linha">Linha que deve ser ressaltada</param>
        public void AlterarCorLinha(int linha){

            DataGridViewRow linhaGrid = this.Grid.Rows[linha];
            linhaGrid.DefaultCellStyle = this.estiloLinhaMutacao;
        }
    }
}
