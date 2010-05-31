using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico.model.engine
{
    public static class Util
    {
        private static Random rnd = new Random();

        /// <summary>
        /// Sorteia um número entre 0 e 1
        /// </summary>
        public static double DecimalAleatorio()
        {
            return rnd.NextDouble();
        }

        /// <summary>
        /// Gera um número inteiro aleatório, maior ou igual ao mínimo e menor que o máximo
        /// </summary>
        /// <param name="minimo">Mínimo que o número gerado poderá assumir</param>
        /// <param name="maximo">Máximo que o número gerado poderá assumir</param>
        /// <returns>Número aleatório</returns>
        public static int InteiroAleatorio(int minimo, int maximo)
        {
            return rnd.Next(minimo, maximo);
        }

        /// <summary>
        /// Trunca um número decimal para N casas após a vírgula
        /// </summary>
        /// <param name="valor">Número decimal</param>
        /// <param name="qtdCasasDecimais">Quantidade de casas decimais</param>
        /// <returns>Número decimal com N casas após a vírgula</returns>
        public static double ParseFormat(double valor, int qtdCasasDecimais)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < qtdCasasDecimais; i++)
            {
                sb.Append("0");
            }

            if (qtdCasasDecimais > 0)
            {
                return double.Parse(valor.ToString(String.Format("0.{0}", sb.ToString())));
            }
            else
            {
                return double.Parse(valor.ToString("0"));
            }
        }

    }
}
