using System.Windows.Forms;
namespace AlgoritmoGenetico.view
{
    partial class TabGeracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabGeracao));
            this.toolbarGeracao = new System.Windows.Forms.ToolStrip();
            this.btAvancar = new System.Windows.Forms.ToolStripButton();
            this.separador1 = new System.Windows.Forms.ToolStripSeparator();
            this.btMutacoes = new System.Windows.Forms.ToolStripButton();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolbarGeracao.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarGeracao
            // 
            this.toolbarGeracao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAvancar,
            this.separador1,
            this.btMutacoes});
            this.toolbarGeracao.Location = new System.Drawing.Point(0, 0);
            this.toolbarGeracao.Name = "toolbarGeracao";
            this.toolbarGeracao.Size = new System.Drawing.Size(583, 25);
            this.toolbarGeracao.TabIndex = 1;
            // 
            // btAvancar
            // 
            this.btAvancar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAvancar.Image = global::AlgoritmoGenetico.Properties.Resources.avancar4;
            this.btAvancar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAvancar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(138, 22);
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // separador1
            // 
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(6, 25);
            // 
            // btMutacoes
            // 
            this.btMutacoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMutacoes.Enabled = false;
            this.btMutacoes.Image = global::AlgoritmoGenetico.Properties.Resources.mutacoes;
            this.btMutacoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btMutacoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMutacoes.Name = "btMutacoes";
            this.btMutacoes.Size = new System.Drawing.Size(139, 22);
            // 
            // panelTab
            // 
            this.panelTab.Controls.Add(this.tabControl);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab.Location = new System.Drawing.Point(0, 25);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(583, 374);
            this.panelTab.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(583, 374);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnDrawItem);
            // 
            // TabGeracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.toolbarGeracao);
            this.Name = "TabGeracao";
            this.Size = new System.Drawing.Size(583, 399);
            this.toolbarGeracao.ResumeLayout(false);
            this.toolbarGeracao.PerformLayout();
            this.panelTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbarGeracao;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripButton btAvancar;
        private System.Windows.Forms.ToolStripSeparator separador1;
        private System.Windows.Forms.ToolStripButton btMutacoes;

    }
}
