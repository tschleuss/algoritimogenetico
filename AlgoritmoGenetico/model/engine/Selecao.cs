using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.model.engine
{
    public class Selecao
    {
        private Random rnd;
        private Geracao geracao;
        public IList<Cromossomo[]> ListaPais;

        public Selecao(Geracao geracao)
        {
            this.rnd = new Random();
            this.geracao = geracao;
            this.ListaPais = new List<Cromossomo[]>();
        }

        /// <summary>
        /// Gera os pais que darão origem aos cromossomos da próxima geração
        /// </summary>
        public void SelecionarPais()
        {
            //gera 1 par para cada 2 indivíduos da população
            int qtdPares = this.geracao.Populacao.Count / 2;

            Cromossomo individuo1 = null;
            Cromossomo individuo2 = null;

            bool descendentesIguais = true;

            for (int i = 1; i <= qtdPares; i++)
            {

                descendentesIguais = true;

                individuo1 = this.SortearCromossomo();

                //O mesmo indivíduo pode ser novamente sorteado em outro par
                //Apenas evita-se a duplicação do indivíduo no mesmo par
                while(descendentesIguais)
                {
                    individuo2 = this.SortearCromossomo();

                    //Se ocorrer duplicação, deve-se efetuar novo sorteio
                    if (individuo1.ID != individuo2.ID)
                    {
                        descendentesIguais = false;
                    }
                }

                this.ListaPais.Add(new Cromossomo[2] { individuo1, individuo2 });
            }

        }

        /// <summary>
        /// Sorteia um cromossomo da geração, utilizando um intervalo randomico que deverá estar entre o intervalo de inicio e fim do cromossomo
        /// </summary>
        /// <returns>Cromossomo sorteado</returns>
        private Cromossomo SortearCromossomo()
        {
            double intervaloSorteado = this.SortearIntervalo();

            Cromossomo sorteado = (from c in this.geracao.Populacao
                                          where intervaloSorteado >= c.IntervaloInicio && intervaloSorteado <= c.IntervaloFim
                                         select c).First();

            return sorteado;
        }

        /// <summary>
        /// Sorteia um número entre 0 e 1
        /// </summary>
        private double SortearIntervalo()
        {
            return this.rnd.NextDouble();
        }

    }
}
