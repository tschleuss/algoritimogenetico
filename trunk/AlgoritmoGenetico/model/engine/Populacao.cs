using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;
using System.Threading;

namespace AlgoritmoGenetico.model.engine
{
    public class Populacao
    {
        //define o tamanho da população
        private int numeroCircuitos = 20;

        private Random rnd;

        private IList<Cromossomo> circuitos;

        public IList<Cromossomo> Circuitos
        {
            get { return circuitos; }
        }

        public Populacao()
        {
            this.circuitos = new List<Cromossomo>();
            rnd = new Random();
        }

        /// <summary>
        /// Cria os circuitos randomicamente
        /// </summary>
        /// <param name="md">Informações das localidades para construção do circuito</param>
        public void GerarPopulacao(MatrizDistancias md)
        {
            int qtdLocalidades = md.QuantidadeLocalidades();

            Cromossomo novoCromossomo = null;

            int tentativas = 0;

            for (int i = 1; i <= numeroCircuitos; i++)
            {
                tentativas = 0;

                novoCromossomo = this.GerarCromossomo(qtdLocalidades, md.PrimeiraLocalidade(), md.UltimaLocalidade());

                //Thread.Sleep(20);

                //gera um novo circuito até achar um que ainda não esteja na população
                while (this.CromossomoDuplicado(novoCromossomo))
                {
                   novoCromossomo = this.GerarCromossomo(qtdLocalidades, md.PrimeiraLocalidade(), md.UltimaLocalidade());
                   tentativas++;

                   if (tentativas == 10000)
                   {
                       //Console.WriteLine("ITEM {0} - Esgotados os circuitos. Qtd de itens na lista: {1}", this.circuitos.Count+1,this.circuitos.Count);
                   }
                }

               //Console.WriteLine("ITEM {0} - Tentativas para gerar {1}", this.circuitos.Count + 1, tentativas);
               this.circuitos.Add(novoCromossomo);
            }
        }

        /// <summary>
        /// Gera um circuito aleatoriamente
        /// </summary>
        private Cromossomo GerarCromossomo(int numerNodos, int primeiraLocalidade, int ultimaLocalidade)
        {
            //deve incluir a ultima localidade no circuito
            ultimaLocalidade++;

            Cromossomo c = new Cromossomo(numerNodos);
            int localidadeSorteada = 0;

            for (int i = 0; i < numerNodos; i++)
            {
                //sorteia uma localidade que esteja entre a primeira e a última definidas na matriz de distancias
                localidadeSorteada = this.rnd.Next(primeiraLocalidade, ultimaLocalidade);

                //não pode repitir localidade no percurso
                while(c.ExisteLocalidade(localidadeSorteada))
                {
                    localidadeSorteada = rnd.Next(primeiraLocalidade, ultimaLocalidade);
                }

               c.AdicionarNodo(localidadeSorteada);
            }

            return c;
        }

        /// <summary>
        /// Verifica se o circuito já existe na população
        /// </summary>
        /// <param name="novoCromossomo">Circuito usado no teste</param>
        /// <returns>Indica se já existe ou nao</returns>
        private bool CromossomoDuplicado(Cromossomo novoCromossomo)
        {
            bool duplicado = false;

            foreach (Cromossomo c in this.circuitos)
            {
                if (c.Equals(novoCromossomo))
                {
                    duplicado = true;
                    break;
                }
            }

            return duplicado;
        }

        public String ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Cromossomo c in this.Circuitos)
            {
                foreach (int localidade in c.Circuito)
                {
                    sb.Append(String.Format("{0} - ", localidade));
                }

                sb.Remove(sb.Length-2, 1);

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

    }
}
