using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.view
{
    public partial class TelaMatrizDistancias : Form
    {
        private MatrizDistancias md;
        private DataGridViewCellStyle estiloLinhaNula;

        public TelaMatrizDistancias(MatrizDistancias md)
        {
            InitializeComponent();

            this.md = md;
            this.estiloLinhaNula = new DataGridViewCellStyle();
            this.estiloLinhaNula.BackColor = Color.Black;
            this.estiloLinhaNula.ForeColor = Color.White;

            PopularGrid();
        }

        private void PopularGrid()
        {
            IList<DataGridViewTextBoxColumn> listaColunas = new List<DataGridViewTextBoxColumn>();

            DataGridViewTextBoxColumn coluna = null;

            for(int i= 0; i < md.QuantidadeLocalidades(true); i++)
            {
                coluna = new DataGridViewTextBoxColumn();
                coluna.ReadOnly = true;
                coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                coluna.HeaderText = i.ToString();
                coluna.Name = i.ToString();
                coluna.Width = 70;
                listaColunas.Add(coluna);
            }

            this.grid.Columns.AddRange(listaColunas.ToArray());

            for (int i = 0; i < this.md.QuantidadeLocalidades(true); i++)
            {
                this.AdicionarLinha(i);
            }

        }

        private void AdicionarLinha(int origem)
        {
            int [] distancias = this.md.BuscarArrayDistancias(origem);

            this.grid.Rows.Add();
            this.grid.Rows[this.grid.Rows.Count - 1].HeaderCell.Value = origem.ToString();

            for (int i = 0; i < distancias.Length; i++)
            {
                grid[i, this.grid.Rows.Count-1].Value = distancias[i];

                if (distancias[i] == 0)
                {
                    grid[i, this.grid.Rows.Count - 1].Style = this.estiloLinhaNula;
                }
            }
        }

    }
}
