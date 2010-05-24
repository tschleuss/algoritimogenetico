using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.model.engine
{
    /// <summary>
    /// Metodologia utilizada: Operador de mapeamento parcial
    /// </summary>
    public class CrossOver
    {
        private IList<Cromossomo[]> listaPais;
        private Populacao populacao;
        private Geracao geracao;

        public CrossOver(Populacao populacao, Geracao geracao, IList<Cromossomo[]> listaPais)
        {
            this.populacao = populacao;
            this.geracao = geracao;
            this.listaPais = listaPais;
        }

        /// <summary>
        /// Realiza cruzamentos randômicos entre cromossomos da geração atual
        /// </summary>
        public void CruzarPais()
        {
            Cromossomo descendente = null;

            bool gerouDuplicado = true;

            foreach(Cromossomo[] pais in this.listaPais)
            {
                //Console.WriteLine("Pais: " + pais[0].ID + "/" + pais[1].ID );

                //gera 2 descendentes
                for (int i = 0; i < pais.Length; i++)
                {
                    gerouDuplicado = true;

                    while (gerouDuplicado)
                    {
                        descendente = GerarCromossomo(pais[0], pais[1], pais[i]);

                        //TODO Verificar se é necessário garantir que os filhos não sejam duplicados
                        //if (!this.populacao.CromossomoDuplicado(descendente))
                        //{
                            this.geracao.AdicionarIndividuo(descendente);
                            gerouDuplicado = false;
                        //}
                    }
                    
                }
            }
        }

        /// <summary>
        /// Gera um cromossomo através do cross-over do pai 1 e 2
        /// </summary>
        /// <param name="pai1">Pai gerador 1</param>
        /// <param name="pai2">Pai gerador 2</param>
        /// <param name="paiOrigemSequenciaCentral">Indica qual dos dois pais irá fornecer a sequencia central do novo cromossomo</param>
        /// <returns></returns>
        private Cromossomo GerarCromossomo(Cromossomo pai1, Cromossomo pai2, Cromossomo paiOrigemSequenciaCentral)
        {
            Cromossomo novoCromossomo = new Cromossomo(paiOrigemSequenciaCentral.Tamanho, this.geracao.Populacao.Count+1);

            #region Descobre quem será o cromossomo que fornecerá os circuitos laterais

            Cromossomo paiOrigemSequenciasLaterais = null;

            if(pai1.ID != paiOrigemSequenciaCentral.ID){
                paiOrigemSequenciasLaterais = pai1;
            }else{
                paiOrigemSequenciasLaterais = pai2;
            }

            #endregion

            #region Gera pontos de cross-over

            //Sorteia dois pontos de crossover, assim serão formados três segmentos no novo cromossomo
            int pontoCrossOver1 = Util.InteiroAleatorio(1, pai1.Tamanho-2);
            int pontoCrossOver2 = Util.InteiroAleatorio(pontoCrossOver1, pai1.Tamanho - 1);

            #endregion

            #region Cria o circuito combinando as sequencias dos dois pais

            for (int i = 0; i < novoCromossomo.Tamanho; i++)
            {
                if (i < pontoCrossOver1 || i > pontoCrossOver2)
                {
                    novoCromossomo.AdicionarNodo(paiOrigemSequenciasLaterais.Circuito[i]);
                }
                else
                {
                    novoCromossomo.AdicionarNodo(paiOrigemSequenciaCentral.Circuito[i]);
                }
            }

            #endregion

            #region Arruma os circuitos repetidos, se existirem

            for (int i = 0; i < novoCromossomo.Tamanho; i++)
            {
                //faz a verificação apenas nos ids laterais
                if (i < pontoCrossOver1 || i > pontoCrossOver2)
                {
                    this.NormalizarCircuitoDuplicado(novoCromossomo, paiOrigemSequenciaCentral, paiOrigemSequenciasLaterais, i, pontoCrossOver1, pontoCrossOver2);
                }
            }

            #endregion

            return novoCromossomo;
        }

        /// <summary>
        /// Troca os números duplicados dentro do cromossomo
        /// </summary>
        /// <param name="novoCromossomo">Cromossomo que foi gerado com circuitos duplicados</param>
        /// <param name="paiOrigemSequenciaCentral">Cromossomo que forneceu os circtuios centrais</param>
        /// <param name="paiOrigemSequenciasLaterais">Cromossomo que forneceu os circuitos laterais</param>
        /// <param name="indiceNodoTeste">Nodo que está sendo testado para verificar se foi duplicado</param>
        /// <param name="pontoCrossOver1">Ponto de cross-over inicial</param>
        /// <param name="pontoCrossOver2">Ponto de cross-over final</param>
        private void NormalizarCircuitoDuplicado(Cromossomo novoCromossomo, Cromossomo paiOrigemSequenciaCentral, Cromossomo paiOrigemSequenciasLaterais, int indiceNodoTeste, int pontoCrossOver1, int pontoCrossOver2)
        {
            int nodo = novoCromossomo.Circuito[indiceNodoTeste];

            for (int i = pontoCrossOver1; i <= pontoCrossOver2; i++)
            {
                //verifica se o circuito já está definido na região central
                if (nodo == paiOrigemSequenciaCentral.Circuito[i])
                {
                    //troca o valor do nodo
                    novoCromossomo.Circuito[indiceNodoTeste] = paiOrigemSequenciasLaterais.Circuito[i];

                    //chama a função recursivamente para verificar se a troca resolveu o problema
                    this.NormalizarCircuitoDuplicado(novoCromossomo, paiOrigemSequenciaCentral, paiOrigemSequenciasLaterais, indiceNodoTeste, pontoCrossOver1, pontoCrossOver2);

                    break;
                }
            }
        }

    }
}
