using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dashboard.ChartControl;

namespace AlgoritmoGenetico.view
{
    public partial class RelatorioAptidao : Form
    {
        public RelatorioAptidao(IList<double> listaAptidao)
        {
            InitializeComponent();
            this.PopularRelatorio(listaAptidao);
        }

        /// <summary>
        /// Gera um gráfico com a evolução da aptidão através das gerações
        /// </summary>
        /// <param name="listaAptidao">Lista de aptidões de cada geração</param>
        public void PopularRelatorio(IList<double> listaAptidao)
        {
            double maiorAptidao = 0;
            double menorAptidao = double.MaxValue;
            int indiceGeracao = 1;
            IList<ChartSeriesValue> listaValores = new List<ChartSeriesValue>();
            ChartSeriesValue chartSeries = null;

            foreach (double aptidaoMedia in listaAptidao)
            {
                chartSeries = new ChartSeriesValue();
                chartSeries.Date = indiceGeracao;
                chartSeries.Value = new decimal(new int[] { int.Parse(aptidaoMedia.ToString()), 0, 0, 0 });

                listaValores.Add(chartSeries);

                if (aptidaoMedia > maiorAptidao)
                {
                    maiorAptidao = aptidaoMedia;
                }

                if (aptidaoMedia < menorAptidao)
                {
                    menorAptidao = aptidaoMedia;
                }

                indiceGeracao++;
            }

            this.graficoAptidao.Series.Values.AddRange(listaValores.ToArray<ChartSeriesValue>());

            this.graficoAptidao.XAxis.Scale.Minimum = 1;
            this.graficoAptidao.XAxis.Scale.Maximum = indiceGeracao;

            this.graficoAptidao.YAxis.Scale.Minimum = int.Parse(menorAptidao.ToString());
            this.graficoAptidao.YAxis.Scale.Maximum = int.Parse(maiorAptidao.ToString());
        }
    }
}
