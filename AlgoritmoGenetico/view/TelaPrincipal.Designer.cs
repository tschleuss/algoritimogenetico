namespace AlgoritmoGenetico
{
    partial class TelaPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.barStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTamanhoPopulacao = new System.Windows.Forms.ToolStripLabel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCircuito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaAptidao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProbab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(614, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // barStatus
            // 
            this.barStatus.Location = new System.Drawing.Point(0, 402);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(614, 22);
            this.barStatus.TabIndex = 2;
            // 
            // barStatusLabel
            // 
            this.barStatusLabel.Name = "barStatusLabel";
            this.barStatusLabel.Size = new System.Drawing.Size(187, 17);
            this.barStatusLabel.Text = "Aguardando novo processamento";
            // 
            // lblTamanhoPopulacao
            // 
            this.lblTamanhoPopulacao.Name = "lblTamanhoPopulacao";
            this.lblTamanhoPopulacao.Size = new System.Drawing.Size(136, 22);
            this.lblTamanhoPopulacao.Text = "Tamanho da população:";
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.grid);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 25);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(614, 377);
            this.panelDataGrid.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaID,
            this.colunaCircuito,
            this.colunaTamanho,
            this.colunaAptidao,
            this.colunaProbab,
            this.colunaIntervalo});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.GridColor = System.Drawing.SystemColors.Control;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(614, 377);
            this.grid.TabIndex = 1;
            // 
            // colunaID
            // 
            this.colunaID.HeaderText = "Nº";
            this.colunaID.Name = "colunaID";
            this.colunaID.ReadOnly = true;
            this.colunaID.Width = 30;
            // 
            // colunaCircuito
            // 
            this.colunaCircuito.HeaderText = "Circuito";
            this.colunaCircuito.Name = "colunaCircuito";
            this.colunaCircuito.ReadOnly = true;
            // 
            // colunaTamanho
            // 
            this.colunaTamanho.HeaderText = "Tamanho";
            this.colunaTamanho.Name = "colunaTamanho";
            this.colunaTamanho.ReadOnly = true;
            this.colunaTamanho.Width = 80;
            // 
            // colunaAptidao
            // 
            this.colunaAptidao.HeaderText = "Aptidão";
            this.colunaAptidao.Name = "colunaAptidao";
            this.colunaAptidao.ReadOnly = true;
            this.colunaAptidao.Width = 80;
            // 
            // colunaProbab
            // 
            this.colunaProbab.HeaderText = "Probab. de Seleção";
            this.colunaProbab.Name = "colunaProbab";
            this.colunaProbab.ReadOnly = true;
            this.colunaProbab.Width = 150;
            // 
            // colunaIntervalo
            // 
            this.colunaIntervalo.HeaderText = "Intervalo";
            this.colunaIntervalo.Name = "colunaIntervalo";
            this.colunaIntervalo.ReadOnly = true;
            this.colunaIntervalo.Width = 120;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 424);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.toolbar);
            this.Name = "TelaPrincipal";
            this.Text = "Caixeiro Viajante - Algoritmos Genéticos";
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.StatusStrip barStatus;
        private System.Windows.Forms.ToolStripStatusLabel barStatusLabel;
        private System.Windows.Forms.ToolStripLabel lblTamanhoPopulacao;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCircuito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaAptidao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaProbab;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIntervalo;
        private System.Windows.Forms.DataGridView grid;
    }
}

