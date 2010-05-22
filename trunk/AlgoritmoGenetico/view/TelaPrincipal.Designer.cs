using System.Windows.Forms;
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
            this.btVisualizarMatriz = new System.Windows.Forms.ToolStripButton();
            this.separador1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAvancarGeracoes = new System.Windows.Forms.ToolStripButton();
            this.separador2 = new System.Windows.Forms.ToolStripSeparator();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.barStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTamanhoPopulacao = new System.Windows.Forms.ToolStripLabel();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolbar.SuspendLayout();
            this.barStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btVisualizarMatriz,
            this.separador1,
            this.btAvancarGeracoes,
            this.separador2});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(579, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // btVisualizarMatriz
            // 
            this.btVisualizarMatriz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btVisualizarMatriz.Image = global::AlgoritmoGenetico.Properties.Resources.matriz;
            this.btVisualizarMatriz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btVisualizarMatriz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVisualizarMatriz.Name = "btVisualizarMatriz";
            this.btVisualizarMatriz.Size = new System.Drawing.Size(135, 22);
            // 
            // separador1
            // 
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(6, 25);
            // 
            // btAvancarGeracoes
            // 
            this.btAvancarGeracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAvancarGeracoes.Enabled = false;
            this.btAvancarGeracoes.Image = global::AlgoritmoGenetico.Properties.Resources.avancarGrupo;
            this.btAvancarGeracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAvancarGeracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAvancarGeracoes.Name = "btAvancarGeracoes";
            this.btAvancarGeracoes.Size = new System.Drawing.Size(198, 22);
            // 
            // separador2
            // 
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(6, 25);
            // 
            // barStatus
            // 
            this.barStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRodape});
            this.barStatus.Location = new System.Drawing.Point(0, 593);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(579, 22);
            this.barStatus.SizingGrip = false;
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
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 25);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(579, 568);
            this.tabControlPrincipal.TabIndex = 3;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AlgoritmoGenetico.Properties.Resources.avancarGrupo;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(198, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // lblRodape
            // 
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(107, 17);
            this.lblRodape.Text = "População iniciada";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 615);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixeiro Viajante - Algoritmos Genéticos";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.barStatus.ResumeLayout(false);
            this.barStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.StatusStrip barStatus;
        private System.Windows.Forms.ToolStripStatusLabel barStatusLabel;
        private System.Windows.Forms.ToolStripLabel lblTamanhoPopulacao;
        private TabControl tabControlPrincipal;
        private ToolStripButton toolStripButton1;
        private ToolStripButton btAvancarGeracoes;
        private ToolStripSeparator separador1;
        private ToolStripButton btVisualizarMatriz;
        private ToolStripSeparator separador2;
        private ToolStripStatusLabel lblRodape;
    }
}

