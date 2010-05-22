namespace AlgoritmoGenetico.view
{
    partial class RelatorioAptidao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioAptidao));
            this.graficoAptidao = new Dashboard.ChartControl.Chart();
            this.SuspendLayout();
            // 
            // graficoAptidao
            // 
            this.graficoAptidao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graficoAptidao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graficoAptidao.Grid.Line.Color = System.Drawing.SystemColors.GrayText;
            this.graficoAptidao.Grid.Line.Dash = System.Drawing.Drawing2D.DashStyle.Dot;
            this.graficoAptidao.Legend.Border.Color = System.Drawing.SystemColors.GrayText;
            this.graficoAptidao.Legend.Border.Dash = System.Drawing.Drawing2D.DashStyle.Dash;
            this.graficoAptidao.Legend.Position = Dashboard.ChartControl.ChartLegendPosition.Bottom;
            this.graficoAptidao.Legend.Visible = true;
            this.graficoAptidao.Location = new System.Drawing.Point(0, 0);
            this.graficoAptidao.Name = "graficoAptidao";
            this.graficoAptidao.Series.Labels.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.graficoAptidao.Series.Line.Color = System.Drawing.Color.LimeGreen;
            this.graficoAptidao.Series.Mark.BorderColor = System.Drawing.Color.DarkBlue;
            this.graficoAptidao.Series.Mark.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.graficoAptidao.Series.Projections.Labels.Rotation = -30F;
            this.graficoAptidao.Series.Projections.Line.Color = System.Drawing.SystemColors.GrayText;
            this.graficoAptidao.Series.Projections.Line.Dash = System.Drawing.Drawing2D.DashStyle.Dash;
            this.graficoAptidao.Series.Projections.Visible = true;
            this.graficoAptidao.Series.Title.Text = "Aptidão da população";
            this.graficoAptidao.Size = new System.Drawing.Size(584, 464);
            this.graficoAptidao.TabIndex = 0;
            this.graficoAptidao.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graficoAptidao.Title.Text = "Evolução da aptidão";
            this.graficoAptidao.XAxis.Line.Color = System.Drawing.SystemColors.WindowText;
            this.graficoAptidao.XAxis.Title.Text = "GERAÇÃO";
            this.graficoAptidao.YAxis.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graficoAptidao.YAxis.Title.Text = "APTIDÃO MÉDIA";
            // 
            // RelatorioAptidao
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(584, 464);
            this.Controls.Add(this.graficoAptidao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioAptidao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evolução da Aptidão";
            this.ResumeLayout(false);

        }

        #endregion

        private Dashboard.ChartControl.Chart graficoAptidao;
    }
}