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

        /// <summary>
        /// Realiza o cálculo das prbabilidades de seleção dos circuitos de uma geração e seus intervalos de início e fim
        /// </summary>
        /// <param name="g">Geração</param>
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

        /// <summary>
        /// Truna um número decimal para 4 casas após a vírgula
        /// </summary>
        /// <param name="valor">Número decimal</param>
        /// <returns>Número decimal com 4 casas após a vírgula</returns>
        private double ParseFormat(double valor)
        {
            return double.Parse(valor.ToString("0.0000"));
        }

    }
}
