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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.btReiniciar = new System.Windows.Forms.ToolStripButton();
            this.separador1 = new System.Windows.Forms.ToolStripSeparator();
            this.btExibirMatriz = new System.Windows.Forms.ToolStripButton();
            this.separador2 = new System.Windows.Forms.ToolStripSeparator();
            this.btAvancarGeracoes = new System.Windows.Forms.ToolStripButton();
            this.separador3 = new System.Windows.Forms.ToolStripSeparator();
            this.btExibirGrafico = new System.Windows.Forms.ToolStripButton();
            this.separador4 = new System.Windows.Forms.ToolStripSeparator();
            this.btExibirResultado = new System.Windows.Forms.ToolStripButton();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.lblRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.barStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTamanhoPopulacao = new System.Windows.Forms.ToolStripLabel();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.toolbar.SuspendLayout();
            this.barStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btReiniciar,
            this.separador1,
            this.btExibirMatriz,
            this.separador2,
            this.btAvancarGeracoes,
            this.separador3,
            this.btExibirGrafico,
            this.separador4,
            this.btExibirResultado});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(664, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // btReiniciar
            // 
            this.btReiniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btReiniciar.Image = global::AlgoritmoGenetico.Properties.Resources.reiniciar;
            this.btReiniciar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btReiniciar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(71, 22);
            this.btReiniciar.Text = "toolStripButton2";
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // separador1
            // 
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(6, 25);
            // 
            // btExibirMatriz
            // 
            this.btExibirMatriz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExibirMatriz.Image = global::AlgoritmoGenetico.Properties.Resources.matriz;
            this.btExibirMatriz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btExibirMatriz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExibirMatriz.Name = "btExibirMatriz";
            this.btExibirMatriz.Size = new System.Drawing.Size(135, 22);
            this.btExibirMatriz.Click += new System.EventHandler(this.btExibirMatriz_Click);
            // 
            // separador2
            // 
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(6, 25);
            // 
            // btAvancarGeracoes
            // 
            this.btAvancarGeracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAvancarGeracoes.Enabled = false;
            this.btAvancarGeracoes.Image = global::AlgoritmoGenetico.Properties.Resources.avancarGrupo;
            this.btAvancarGeracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAvancarGeracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAvancarGeracoes.Name = "btAvancarGeracoes";
            this.btAvancarGeracoes.Size = new System.Drawing.Size(157, 22);
            this.btAvancarGeracoes.Click += new System.EventHandler(this.btAvancarGeracoes_Click);
            // 
            // separador3
            // 
            this.separador3.Name = "separador3";
            this.separador3.Size = new System.Drawing.Size(6, 25);
            // 
            // btExibirGrafico
            // 
            this.btExibirGrafico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExibirGrafico.Image = global::AlgoritmoGenetico.Properties.Resources.aptidao;
            this.btExibirGrafico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btExibirGrafico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExibirGrafico.Name = "btExibirGrafico";
            this.btExibirGrafico.Size = new System.Drawing.Size(135, 22);
            this.btExibirGrafico.Click += new System.EventHandler(this.btVisualizarGrafico_Click);
            // 
            // separador4
            // 
            this.separador4.Name = "separador4";
            this.separador4.Size = new System.Drawing.Size(6, 25);
            this.separador4.Visible = false;
            // 
            // btExibirResultado
            // 
            this.btExibirResultado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExibirResultado.Image = global::AlgoritmoGenetico.Properties.Resources.resultado;
            this.btExibirResultado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btExibirResultado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExibirResultado.Name = "btExibirResultado";
            this.btExibirResultado.Size = new System.Drawing.Size(115, 22);
            this.btExibirResultado.Text = "toolStripButton2";
            this.btExibirResultado.Visible = false;
            this.btExibirResultado.Click += new System.EventHandler(this.btExibirResultado_Click);
            // 
            // barStatus
            // 
            this.barStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRodape});
            this.barStatus.Location = new System.Drawing.Point(0, 593);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(664, 22);
            this.barStatus.SizingGrip = false;
            this.barStatus.TabIndex = 2;
            // 
            // lblRodape
            // 
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(107, 17);
            this.lblRodape.Text = "População iniciada";
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
            this.tabControlPrincipal.Size = new System.Drawing.Size(664, 568);
            this.tabControlPrincipal.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 615);
            this.Controls.Add(this.tabControlPrincipal);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private ToolStripButton btAvancarGeracoes;
        private ToolStripSeparator separador2;
        private ToolStripButton btExibirMatriz;
        private ToolStripSeparator separador3;
        private ToolStripStatusLabel lblRodape;
        private ToolStripButton btExibirGrafico;
        private ToolStripSeparator separador4;
        private ToolStripButton btExibirResultado;
        private ToolStripSeparator separador1;
        private ToolStripButton btReiniciar;
    }
}

