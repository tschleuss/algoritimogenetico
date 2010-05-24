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

        private MatrizDistancias md;

        public Aptidao(MatrizDistancias md)
        {
            this.md = md;
        }

        /// <summary>
        /// Calcula a aptidão bruta de cada circuito da geração
        /// </summary>
        /// <param name="populacaoAtual">Lista de circuitos</param>
        public void CalcularAptidaoBruta(IList<Cromossomo> populacaoAtual)
        {
            Cromossomo maiorCircuito = this.ProcurarMaiorCircuito(populacaoAtual);

           //Console.WriteLine("\nAptidão bruta:");

            int i = 1;
            foreach (Cromossomo c in populacaoAtual)
            {
                c.AptidaoBruta = maiorCircuito.ComprimentoCircuito - c.CalcularComprimentoCircuito(md);

                //Console.WriteLine(String.Format("{0} - {1}", i, c.AptidaoBruta));
                i++;
            }
        }

        /// <summary>
        /// Com base na população da geração atual, calcula a aptidão populacional
        /// </summary>
        /// <param name="g">Geração atual</param>
        public void CalcularAptidaoPopulacional(Geracao g)
        {
            foreach (Cromossomo c in g.Populacao)
            {
                g.AptidaoPopulacional += c.AptidaoBruta;
            }

           //Console.WriteLine(String.Format("\nAptidão populacional: {0}", g.AptidaoPopulacional));
        }

        /// <summary>
        /// Descobre qual dos circuitos tem o maior comprimento
        /// </summary>
        /// <param name="populacaoAtual">Lista de circuitos da geração atual</param>
        private Cromossomo ProcurarMaiorCircuito(IList<Cromossomo> populacaoAtual)
        {
            int maiorComprimento = 0;
            int comprimentoAtual = 0;

            //Console.WriteLine("\nTamanho dos percursos:");

            Cromossomo maiorCircuito = null;

            int i = 1;
            foreach (Cromossomo c in populacaoAtual)
            {
                comprimentoAtual = c.CalcularComprimentoCircuito(this.md);

                //achou um comprimento atual
                if (comprimentoAtual > maiorComprimento)
                {
                    maiorComprimento = comprimentoAtual;
                    maiorCircuito = c;
                }

                //Console.WriteLine(String.Format("{0} - {1}", i, c.CalcularComprimentoCircuito(md)));
                i++;
            }

            return maiorCircuito;
        }

    }
}
