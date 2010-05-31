using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlgoritmoGenetico.model;

namespace AlgoritmoGenetico.view
{
    public partial class ResultadoFinal : Form
    {

        private Cromossomo resultado;

        public ResultadoFinal(Cromossomo resultado)
        {
            InitializeComponent();

            this.resultado = resultado;

            this.CarregarDados();
        }

        /// <summary>
        /// Carrega na tela os dados do cromossomo com menor caminho encontrado pelo programa
        /// </summary>
        public void CarregarDados()
        {
            this.lblGeracaoValor.Text = this.resultado.GeracaoID.ToString();
            this.lblIDValor.Text = this.resultado.ID.ToString(); ;
            this.lblMenorCaminhoValor.Text = this.resultado.CircuitoString;
            this.lblMutacaoValor.Text = (this.resultado.GenesMutados == null ? "Não" : "Sim");
            this.lblTamanhoValor.Text = this.resultado.ComprimentoCircuito.ToString();
        }

    }
}
