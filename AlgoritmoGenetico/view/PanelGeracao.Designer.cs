using System.Windows.Forms;
namespace AlgoritmoGenetico.view
{
    partial class PanelGeracao
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAptidaoPopulacional = new System.Windows.Forms.Label();
            this.LblAptidaoPopulacionalValor = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCircuito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaMutacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAptidao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProbab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaComprimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panelContainer.Controls.Add(this.Grid);
            //this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Size = new System.Drawing.Size(660, 463);
            this.panelContainer.TabIndex = 0;
            // 
            // grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaID,
            this.colunaCircuito,
            this.colunaMutacao,
            this.colunaAptidao,
            this.colunaComprimento,
            this.colunaProbab,
            this.colunaIntervalo});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.TabIndex = 2;
            this.Grid.AutoGenerateColumns = false;
            this.Grid.BorderStyle = BorderStyle.FixedSingle;
            // 
            // colunaID
            // 
            this.colunaID.DataPropertyName = "ID";
            this.colunaID.HeaderText = "Nº";
            this.colunaID.Name = "colunaID";
            this.colunaID.ReadOnly = true;
            this.colunaID.Width = 30;
            this.colunaID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colunaID.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 
            // colunaCircuito
            // 
            this.colunaCircuito.DataPropertyName = "CircuitoString";
            this.colunaCircuito.HeaderText = "Circuito";
            this.colunaCircuito.Name = "colunaCircuito";
            this.colunaCircuito.ReadOnly = true;
            this.colunaCircuito.Width = 105;
            this.colunaCircuito.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colunaCircuito.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // colunaMutacao
            // 
            this.colunaMutacao.DataPropertyName = "GenesMutadosString";
            this.colunaMutacao.HeaderText = "Mutação";
            this.colunaMutacao.Name = "colunaMutacao";
            this.colunaMutacao.ReadOnly = true;
            this.colunaMutacao.Width = 90;
            this.colunaMutacao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colunaMutacao.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // colunaAptidao
            // 
            this.colunaAptidao.DataPropertyName = "AptidaoBruta";
            this.colunaAptidao.HeaderText = "Aptidão";
            this.colunaAptidao.Name = "colunaAptidao";
            this.colunaAptidao.ReadOnly = true;
            this.colunaAptidao.Width = 80;
            this.colunaAptidao.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colunaAptidao.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //colunaComprimento
            this.colunaComprimento.DataPropertyName = "ComprimentoCircuito";
            this.colunaComprimento.HeaderText = "Comprimento";
            this.colunaComprimento.Name = "colunaComprimento";
            this.colunaComprimento.ReadOnly = true;
            this.colunaComprimento.Width = 80;
            this.colunaComprimento.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colunaComprimento.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // colunaProbab
            // 
            this.colunaProbab.DataPropertyName = "ProbabSelecao";
            this.colunaProbab.HeaderText = "Probab. de Seleção";
            this.colunaProbab.Name = "colunaProbab";
            this.colunaProbab.ReadOnly = true;
            this.colunaProbab.Width = 140;
            this.colunaProbab.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colunaProbab.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // colunaIntervalo
            // 
            this.colunaIntervalo.DataPropertyName = "IntervaloTotal";
            this.colunaIntervalo.HeaderText = "Intervalo";
            this.colunaIntervalo.Name = "colunaIntervalo";
            this.colunaIntervalo.ReadOnly = true;
            this.colunaIntervalo.Width = 120;
            this.colunaIntervalo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.colunaIntervalo.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // lblAptidaoPopulacional
            // 
            this.lblAptidaoPopulacional.AutoSize = true;
            this.lblAptidaoPopulacional.Location = new System.Drawing.Point(3, 470);
            this.lblAptidaoPopulacional.Name = "lblAptidaoPopulacional";
            this.lblAptidaoPopulacional.Size = new System.Drawing.Size(110, 13);
            this.lblAptidaoPopulacional.TabIndex = 0;
            this.lblAptidaoPopulacional.Text = "Aptidão Populacional:";
            // 
            // LblAptidaoPopulacionalValor
            // 
            this.LblAptidaoPopulacionalValor.AutoSize = true;
            this.LblAptidaoPopulacionalValor.Location = new System.Drawing.Point(115, 468);
            this.LblAptidaoPopulacionalValor.Name = "LblAptidaoPopulacionalValor";
            this.LblAptidaoPopulacionalValor.Size = new System.Drawing.Size(43, 13);
            this.LblAptidaoPopulacionalValor.TabIndex = 1;
            this.LblAptidaoPopulacionalValor.Text = "VALOR";
            this.LblAptidaoPopulacionalValor.Font = new System.Drawing.Font("Arial", 10f, System.Drawing.FontStyle.Bold);
            // 
            // PanelGeracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblAptidaoPopulacionalValor);
            this.Controls.Add(this.lblAptidaoPopulacional);
            this.Controls.Add(this.panelContainer);
            this.Name = "PanelGeracao";
            this.Size = new System.Drawing.Size(568, 402);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContainer;
        private DataGridViewTextBoxColumn colunaID;
        private DataGridViewTextBoxColumn colunaCircuito;
        private DataGridViewTextBoxColumn colunaMutacao;
        private DataGridViewTextBoxColumn colunaAptidao;
        private DataGridViewTextBoxColumn colunaProbab;
        private DataGridViewTextBoxColumn colunaIntervalo;
        private DataGridViewTextBoxColumn colunaComprimento;
        private Label lblAptidaoPopulacional;
        public DataGridView Grid;
        public Label LblAptidaoPopulacionalValor;
    }
}
