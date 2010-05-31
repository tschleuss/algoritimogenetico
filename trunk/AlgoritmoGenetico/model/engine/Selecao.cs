using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.model.engine
{
    public class Selecao
    {
        public IList<Cromossomo[]> ListaPais { get; set; }
        private Geracao geracao;

        public Selecao(Geracao geracao)
        {
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

            bool paisIguais = true;

            for (int i = 1; i <= qtdPares; i++)
            {

                paisIguais = true;

                individuo1 = this.SortearCromossomo();

                //Se não encontrou um individuo, permite duplicação
                if (individuo1 == null)
                {
                    individuo1 = this.geracao.Populacao.First();
                    individuo2 = individuo1;
                }
                else
                {
                    //O mesmo indivíduo pode ser novamente sorteado em outro par
                    //Apenas evita-se a duplicação do indivíduo no mesmo par
                    while (paisIguais)
                    {
                        individuo2 = this.SortearCromossomo();

                        //Se não encontrou um individuo, permite duplicação
                        if (individuo2 == null)
                        {
                            individuo2 = individuo1;
                            paisIguais = false;
                        }
                        //Se ocorrer duplicação, deve-se efetuar novo sorteio
                        else if (individuo1.ID != individuo2.ID || (individuo2.IntervaloInicio == 0 && individuo2.IntervaloFim == 1))
                        {
                            paisIguais = false;
                        }
                    }
                }

                this.ListaPais.Add(new Cromossomo[2] { individuo1, individuo2 });
            }

        }

        /// <summary>
        /// Sorteia um cromossomo da geração, utilizando um intervalo randomico que deverá estar entre 
        /// o intervalo de inicio e fim do cromossomo. Não sorteia um mesmo cromossomo para mais de 2 pares
        /// </summary>
        /// <returns>Cromossomo sorteado</returns>
        private Cromossomo SortearCromossomo()
        {
            double intervaloSorteado = Util.DecimalAleatorio();

            IList<Cromossomo> lista = (from c in this.geracao.Populacao
                                   where intervaloSorteado >= c.IntervaloInicio && intervaloSorteado <= c.IntervaloFim
                                   select c).ToList();

            if (lista.Count > 1)
            {
                return null;
            }
            else
            {
                return lista.FirstOrDefault();
            }

        }


    }
}
