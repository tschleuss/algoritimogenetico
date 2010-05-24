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
        /// <param name="geracao">Geração</param>
        public void CalcularProbabilidade(Geracao geracao)
        {
            double aptidaoPopulacional = geracao.AptidaoPopulacional;

            //Console.WriteLine("\nProbabilidade de selecao:");

            int i = 1;
            Cromossomo penultimo = null;
            foreach (Cromossomo c in geracao.Populacao)
            {
                if (c.AptidaoBruta != 0)
                {
                    c.ProbabSelecao = Util.ParseFormat(c.AptidaoBruta / aptidaoPopulacional);

                    c.IntervaloInicio = Util.ParseFormat(this.intervaloAtual);
                    c.IntervaloFim = Util.ParseFormat(c.IntervaloInicio + c.ProbabSelecao);

                    this.intervaloAtual = c.IntervaloFim;
                    penultimo = c;
                }
                else
                {
                    c.IntervaloInicio = 1;
                    c.IntervaloFim = 1;
                }

                //Console.WriteLine(String.Format("{0} - {1} ({2} - {3})", i, c.ProbabSelecao, c.IntervaloInicio, c.IntervaloFim));
                i++;
            }

            if (penultimo != null)
            {
                //garante que o intervalo final do penúltimo cromossomo da lista seja 1
                penultimo.IntervaloFim = 1;
            }

        }

    }
}
