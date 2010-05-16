using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AlgoritmoGenetico.Properties;

namespace AlgoritmoGenetico.model.core
{
    public class MatrizDistancias
    {
        private Dictionary<int, IList<int>> dicValores;

        private int primeiraLocalidade;
        private int ultimaLocalidade;

        public MatrizDistancias()
        {
            this.dicValores = new Dictionary<int, IList<int>>();
        }
        
        /// <summary>
        /// Lê o arquivo txt 'matrizDistancias.txt' e monta a tabela com as distâncias entre as localidades
        /// </summary>
        public void CarregarMatriz()
        {
            IList<String> valoresTXT = Resources.matrizDistancias.Split(System.Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            IList<string> valorLinha = null;

            int localidadeAtual = 0;
            int distanciaAtual = 0;
            int tokenDistancia = 0;
            IList<int> distancias = null;

            foreach(String valor in valoresTXT)
            {
                valorLinha = valor.Split(':');

                #region Localidade Atual 

                if (valorLinha.Count > 1)
                {
                    if (localidadeAtual != 0)
                    {
                        dicValores.Add(localidadeAtual, distancias);
                        distancias = null;
                    }
                    else
                    {
                        primeiraLocalidade = int.Parse(valorLinha[0]);
                    }

                    localidadeAtual = int.Parse(valorLinha[0]);
                    ultimaLocalidade = localidadeAtual;
                }

                #endregion

                else
                {

                    if (distancias == null)
                    {
                        distancias = new List<int>();
                    }

                    valorLinha = valor.Split('-');

                    #region Distancia definida no txt
                    if (valorLinha.Count == 2)
                    {
                        distanciaAtual = int.Parse(valorLinha[1]);
                        distancias.Add(distanciaAtual);
                    }
                    #endregion
                    else
                    {
                        tokenDistancia = int.Parse(valorLinha[0]);

                        #region Destino = origem
                        if (tokenDistancia == localidadeAtual)
                        {
                            distanciaAtual = 0;
                        }
                        #endregion

                        #region Distancia equivalente a de outro valor já existente no dicionário
                        else
                        {
                            distanciaAtual = dicValores[tokenDistancia][localidadeAtual - 1];
                        }
                        #endregion

                        distancias.Add(distanciaAtual);
                    }

                }
            }

            if (distancias != null)
            {
                dicValores.Add(localidadeAtual, distancias);
            }
            
        }

        /// <summary>
        /// Busca a primeira localidade definida na matriz de distancias
        /// </summary>
        public int PrimeiraLocalidade()
        {
            return this.primeiraLocalidade;
        }

        /// <summary>
        /// Busca a última localidade definida na matriz de distancias
        /// </summary>
        public int UltimaLocalidade()
        {
            return this.ultimaLocalidade;
        }

        /// <summary>
        /// Busca quantidade de localidades configurada na matriz de distancias
        /// </summary>
        /// <returns>Quantidade de localidades</returns>
        public int QuantidadeLocalidades()
        {
            return this.dicValores.Count;
        }

        /// <summary>
        /// Busca a distância entre a localidade de origem e a de destino
        /// </summary>
        /// <param name="origem">Localidade de origem</param>
        /// <param name="destino">Localidade de destino</param>
        /// <returns>Distância entre os dois pontos</returns>
        public int BuscarDistancia(int origem, int destino)
        {

            if (origem == destino)
            {
                return 0;
            }

            return this.dicValores[origem][destino-1];

        }

        /// <summary>
        /// Busca os valores da matriz de distância
        /// </summary>
        /// <returns>Valores da matriz de distância</returns>
        public override string ToString(){

            StringBuilder sb = new StringBuilder();

            foreach(KeyValuePair<int, IList<int>> kvp in this.dicValores)
            {

                sb.Append(String.Format("{0}:", kvp.Key));

                sb.Append(Environment.NewLine);

                for(int i = 0; i < kvp.Value.Count; i++)
                {
                    sb.Append(String.Format("{0} - {1}", i+1, kvp.Value[i]));
                    sb.Append(Environment.NewLine);
                }

                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);

            }

            return sb.ToString();

        }

    }
}
