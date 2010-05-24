using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.model.engine
{
    /// <summary>
    /// Metodologia utilizada: Troca recíproca
    /// </summary>
    public class MutacaoGenetica
    {
        //Fixa a probabilidade de mutação da geração
        private double probabMutacao = 0.03;
        private Geracao geracao;
        //probabilidade que cada gene tem de ser mutado
        private double probabMutacaoGene;

        public MutacaoGenetica(Geracao geracao)
        {
            this.geracao = geracao;
            //1 / número de genes de cada indivíduo
            this.probabMutacaoGene = 1.0 / geracao.Populacao[0].Tamanho;
        }

        /// <summary>
        /// Gera mutações genéticas nos circuitos da geração atual
        /// </summary>
        public void GerarMutacoes()
        {
            double intervaloSorteado;

            double intervaloMutacao1;
            double intervaloMutacao2;

            int indiceGene1 = 0;
            int indiceGene2 = 0;

            bool indiceIgual = true;

            foreach (Cromossomo c in this.geracao.Populacao)
            {

                indiceIgual = true;

                intervaloSorteado = Util.DecimalAleatorio();

                //verifica se o cromossomo deverá sofrer mutação
                if (intervaloSorteado <= probabMutacao)
                {
                    //gene 1
                    intervaloMutacao1 = Util.DecimalAleatorio();

                    //descobre o índice do gene no circuito
                    indiceGene1 = (int)Math.Truncate(intervaloMutacao1 / this.probabMutacaoGene);

                    //garante que não sejam os mesmos índices
                    while (indiceIgual)
                    {
                        //gene 2
                        intervaloMutacao2 = Util.DecimalAleatorio();

                        //descobre o índice do gene no circuito
                        indiceGene2 = (int)Math.Truncate(intervaloMutacao2 / this.probabMutacaoGene);

                        if (indiceGene1 != indiceGene2)
                        {
                            indiceIgual = false;
                        }
                    }

                    //Console.WriteLine("MUTAÇÃO - Geração {0}: {1} por {2}", this.geracao.ID, indiceGene1, indiceGene2);
                    c.GerarMutacao(indiceGene1, indiceGene2);

                }
            }
        }

    }
}
