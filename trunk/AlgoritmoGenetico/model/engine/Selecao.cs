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
        private Dictionary<int, int> qtdSelecoesPais;
        private int maximoVezesSorteado = 2;

        public Selecao(Geracao geracao)
        {
            this.geracao = geracao;
            this.ListaPais = new List<Cromossomo[]>();
            this.qtdSelecoesPais = new Dictionary<int, int>();
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

                //O mesmo indivíduo pode ser novamente sorteado em outro par
                //Apenas evita-se a duplicação do indivíduo no mesmo par
                while(paisIguais)
                {
                    individuo2 = this.SortearCromossomo();

                    //Se ocorrer duplicação, deve-se efetuar novo sorteio
                    if (individuo1.ID != individuo2.ID)
                    {
                        paisIguais = false;
                    }
                }

                this.ContabilizarQtdParesPorPai(individuo1.ID, individuo2.ID);
                this.ListaPais.Add(new Cromossomo[2] { individuo1, individuo2 });
            }

        }

        /// <summary>
        /// Contabiliza a quantidade de vezes que um cromossomo aparece nos pares
        /// </summary>
        /// <param name="pai1">Primeiro pai do par</param>
        /// <param name="pai2">Segundo pai do par</param>
        private void ContabilizarQtdParesPorPai(int pai1, int pai2)
        {
            if (this.qtdSelecoesPais.ContainsKey(pai1))
            {
                this.qtdSelecoesPais[pai1]++;
            }
            else
            {
                this.qtdSelecoesPais.Add(pai1, 1);
            }

            if (this.qtdSelecoesPais.ContainsKey(pai2))
            {
                this.qtdSelecoesPais[pai2]++;
            }
            else
            {
                this.qtdSelecoesPais.Add(pai2, 1);
            }
        }

        /// <summary>
        /// Sorteia um cromossomo da geração, utilizando um intervalo randomico que deverá estar entre 
        /// o intervalo de inicio e fim do cromossomo. Não sorteia um mesmo cromossomo para mais de 2 pares
        /// </summary>
        /// <returns>Cromossomo sorteado</returns>
        private Cromossomo SortearCromossomo()
        {
            double intervaloSorteado;

            bool excedeuMaximoVezes = true;
            Cromossomo sorteado = null;

            while (excedeuMaximoVezes)
            {

                intervaloSorteado = Util.DecimalAleatorio();

                sorteado = (from c in this.geracao.Populacao
                            where intervaloSorteado >= c.IntervaloInicio && intervaloSorteado <= c.IntervaloFim
                            select c).First();

                /*
                //TODO Se for necessário evitar duplicações, usar  o código abaixo
                if (this.qtdSelecoesPais.ContainsKey(sorteado.ID))
                {
                    //não permite que o mesmo circuito seja o pai de muitos descendentes
                    if (this.qtdSelecoesPais[sorteado.ID] < this.maximoVezesSorteado)
                    {
                        excedeuMaximoVezes = false;
                    }
                }
                else
                {*/
                    excedeuMaximoVezes = false;
                //}
            }

            return sorteado;
        }


    }
}
