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
                    c.ProbabSelecao = c.AptidaoBruta / aptidaoPopulacional;
                    c.ProbabSelecao = double.Parse(c.ProbabSelecao.ToString("0.0000"));
                }


                c.IntervalorInicio = this.intervaloAtual;
                c.IntervalorFim = c.IntervalorInicio + c.ProbabSelecao;

                this.intervaloAtual = c.IntervalorFim;

                Console.WriteLine(String.Format("{0} - {1} ({2} - {3})", i, c.ProbabSelecao, c.IntervalorInicio, c.IntervalorFim));
                i++;
            }
        }

    }
}
