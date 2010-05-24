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
        /// Truna um número decimal para 4 casas após a vírgula
        /// </summary>
        /// <param name="valor">Número decimal</param>
        /// <returns>Número decimal com 4 casas após a vírgula</returns>
        public static double ParseFormat(double valor)
        {
            return double.Parse(valor.ToString("0.0000"));
        }

    }
}
