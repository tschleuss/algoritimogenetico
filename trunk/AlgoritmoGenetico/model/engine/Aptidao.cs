using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.model.engine
{
    /// <summary>
    /// Metodologia utilizada: Diferença ao maior
    /// </summary>
    public class Aptidao
    {

        private Cromossomo maiorCircuito;

        private MatrizDistancias md;

        public Aptidao(MatrizDistancias md)
        {
            this.md = md;
        }

        public void CalcularAptidaoBruta(IList<Cromossomo> populacaoAtual)
        {
            this.ProcurarMaiorCircuito(populacaoAtual);

            Console.WriteLine("\nAptidão bruta:");

            int i = 1;
            foreach (Cromossomo c in populacaoAtual)
            {
                c.AptidaoBruta = this.maiorCircuito.CalcularComprimentoCircuito(md) - c.CalcularComprimentoCircuito(md);

                Console.WriteLine(String.Format("{0} - {1}", i, c.AptidaoBruta));
                i++;
            }
        }

        public void CalcularAptidaoPopulacional(Geracao g)
        {
            foreach (Cromossomo c in g.Populacao)
            {
                g.AptidaoPopulacional += c.AptidaoBruta;
            }

            Console.WriteLine(String.Format("\nAptidão populacional: {0}", g.AptidaoPopulacional));
        }

        /// <summary>
        /// Descobre qual dos circuitos tem o maior comprimento
        /// </summary>
        /// <param name="populacaoAtual">Lista de circuitos da geração atual</param>
        private void ProcurarMaiorCircuito(IList<Cromossomo> populacaoAtual)
        {
            int maiorComprimento = 0;
            int comprimentoAtual = 0;

            Console.WriteLine("\nTamanho dos percursos:");

            int i = 1;
            foreach (Cromossomo c in populacaoAtual)
            {
                comprimentoAtual = c.CalcularComprimentoCircuito(this.md);

                //achou um comprimento atual
                if (comprimentoAtual > maiorComprimento)
                {
                    maiorComprimento = comprimentoAtual;
                    this.maiorCircuito = c;
                }

                Console.WriteLine(String.Format("{0} - {1}", i, c.CalcularComprimentoCircuito(md)));
                i++;
            }
        }

    }
}
