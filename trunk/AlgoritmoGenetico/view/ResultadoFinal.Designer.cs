namespace AlgoritmoGenetico.view
{
    partial class ResultadoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoFinal));
            this.lblMenorCaminho = new System.Windows.Forms.Label();
            this.lblMenorCaminhoValor = new System.Windows.Forms.Label();
            this.fieldsetInfo = new System.Windows.Forms.GroupBox();
            this.lblMutacaoValor = new System.Windows.Forms.Label();
            this.lblIDValor = new System.Windows.Forms.Label();
            this.lblGeracaoValor = new System.Windows.Forms.Label();
            this.lblMutacao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblGeracao = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblTamanhoValor = new System.Windows.Forms.Label();
            this.fieldsetInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenorCaminho
            // 
            this.lblMenorCaminho.AutoSize = true;
            this.lblMenorCaminho.Location = new System.Drawing.Point(109, 8);
            this.lblMenorCaminho.Name = "lblMenorCaminho";
            this.lblMenorCaminho.Size = new System.Drawing.Size(140, 13);
            this.lblMenorCaminho.TabIndex = 0;
            this.lblMenorCaminho.Text = "Menor caminho encontrado:";
            // 
            // lblMenorCaminhoValor
            // 
            this.lblMenorCaminhoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenorCaminhoValor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMenorCaminhoValor.Location = new System.Drawing.Point(94, 26);
            this.lblMenorCaminhoValor.Name = "lblMenorCaminhoValor";
            this.lblMenorCaminhoValor.Size = new System.Drawing.Size(167, 26);
            this.lblMenorCaminhoValor.TabIndex = 1;
            this.lblMenorCaminhoValor.Text = "VALOR";
            this.lblMenorCaminhoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldsetInfo
            // 
            this.fieldsetInfo.Controls.Add(this.lblTamanhoValor);
            this.fieldsetInfo.Controls.Add(this.lblTamanho);
            this.fieldsetInfo.Controls.Add(this.lblMutacaoValor);
            this.fieldsetInfo.Controls.Add(this.lblIDValor);
            this.fieldsetInfo.Controls.Add(this.lblGeracaoValor);
            this.fieldsetInfo.Controls.Add(this.lblMutacao);
            this.fieldsetInfo.Controls.Add(this.lblID);
            this.fieldsetInfo.Controls.Add(this.lblGeracao);
            this.fieldsetInfo.Location = new System.Drawing.Point(12, 60);
            this.fieldsetInfo.Name = "fieldsetInfo";
            this.fieldsetInfo.Size = new System.Drawing.Size(324, 87);
            this.fieldsetInfo.TabIndex = 2;
            this.fieldsetInfo.TabStop = false;
            this.fieldsetInfo.Text = "Outras informações";
            // 
            // lblMutacaoValor
            // 
            this.lblMutacaoValor.AutoSize = true;
            this.lblMutacaoValor.Location = new System.Drawing.Point(273, 25);
            this.lblMutacaoValor.Name = "lblMutacaoValor";
            this.lblMutacaoValor.Size = new System.Drawing.Size(43, 13);
            this.lblMutacaoValor.TabIndex = 5;
            this.lblMutacaoValor.Text = "VALOR";
            // 
            // lblIDValor
            // 
            this.lblIDValor.AutoSize = true;
            this.lblIDValor.Location = new System.Drawing.Point(85, 57);
            this.lblIDValor.Name = "lblIDValor";
            this.lblIDValor.Size = new System.Drawing.Size(43, 13);
            this.lblIDValor.TabIndex = 4;
            this.lblIDValor.Text = "VALOR";
            // 
            // lblGeracaoValor
            // 
            this.lblGeracaoValor.AutoSize = true;
            this.lblGeracaoValor.Location = new System.Drawing.Point(85, 25);
            this.lblGeracaoValor.Name = "lblGeracaoValor";
            this.lblGeracaoValor.Size = new System.Drawing.Size(43, 13);
            this.lblGeracaoValor.TabIndex = 3;
            this.lblGeracaoValor.Text = "VALOR";
            // 
            // lblMutacao
            // 
            this.lblMutacao.AutoSize = true;
            this.lblMutacao.Location = new System.Drawing.Point(147, 25);
            this.lblMutacao.Name = "lblMutacao";
            this.lblMutacao.Size = new System.Drawing.Size(126, 13);
            this.lblMutacao.TabIndex = 2;
            this.lblMutacao.Text = "Possui gene c/ mutação:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(73, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID do circuito:";
            // 
            // lblGeracao
            // 
            this.lblGeracao.AutoSize = true;
            this.lblGeracao.Location = new System.Drawing.Point(28, 25);
            this.lblGeracao.Name = "lblGeracao";
            this.lblGeracao.Size = new System.Drawing.Size(51, 13);
            this.lblGeracao.TabIndex = 0;
            this.lblGeracao.Text = "Geração:";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(166, 57);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(107, 13);
            this.lblTamanho.TabIndex = 6;
            this.lblTamanho.Text = "Tamanho do circuito:";
            // 
            // lblTamanhoValor
            // 
            this.lblTamanhoValor.AutoSize = true;
            this.lblTamanhoValor.Location = new System.Drawing.Point(273, 57);
            this.lblTamanhoValor.Name = "lblTamanhoValor";
            this.lblTamanhoValor.Size = new System.Drawing.Size(43, 13);
            this.lblTamanhoValor.TabIndex = 7;
            this.lblTamanhoValor.Text = "VALOR";
            // 
            // ResultadoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 158);
            this.Controls.Add(this.fieldsetInfo);
            this.Controls.Add(this.lblMenorCaminhoValor);
            this.Controls.Add(this.lblMenorCaminho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultadoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado do processamento";
            this.fieldsetInfo.ResumeLayout(false);
            this.fieldsetInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenorCaminho;
        private System.Windows.Forms.Label lblMenorCaminhoValor;
        private System.Windows.Forms.GroupBox fieldsetInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblGeracao;
        private System.Windows.Forms.Label lblMutacao;
        private System.Windows.Forms.Label lblMutacaoValor;
        private System.Windows.Forms.Label lblIDValor;
        private System.Windows.Forms.Label lblGeracaoValor;
        private System.Windows.Forms.Label lblTamanhoValor;
        private System.Windows.Forms.Label lblTamanho;
    }
}