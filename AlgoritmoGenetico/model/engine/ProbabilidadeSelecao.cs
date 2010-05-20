using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.model.engine
{
    public class ProbabilidadeSelecao
    {

        private double intervaloAtual;

        public ProbabilidadeSelecao()
        {
            this.intervaloAtual = 0;
        }

        public void CalcularProbabilidade(Geracao g)
        {
            double aptidaoPopulacional = g.AptidaoPopulacional;

            Console.WriteLine("\nProbabilidade de selecao:");

            int i = 1;
            foreach (Cromossomo c in g.Populacao)
            {
                if (c.AptidaoBruta != 0)
                {
                    c.ProbabSelecao = this.ParseFormat(c.AptidaoBruta / aptidaoPopulacional);
                }


                c.IntervaloInicio = this.ParseFormat(this.intervaloAtual);
                c.IntervaloFim = this.ParseFormat(c.IntervaloInicio + c.ProbabSelecao);

                this.intervaloAtual = c.IntervaloFim;

                Console.WriteLine(String.Format("{0} - {1} ({2} - {3})", i, c.ProbabSelecao, c.IntervaloInicio, c.IntervaloFim));
                i++;
            }
        }

        private double ParseFormat(double valor)
        {
            return double.Parse(valor.ToString("0.0000"));
        }

    }
}
