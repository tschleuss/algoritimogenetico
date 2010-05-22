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

        public IList<Geracao> ListaGeracoes;
        public Geracao GeracaoAtual { get; set; }

        private int qtdLocalidades;
        private int primeiraLocalidade;
        private int ultimaLocalidade;

        public Populacao(MatrizDistancias md)
        {
            this.ListaGeracoes = new List<Geracao>();
            this.rnd = new Random();

            this.qtdLocalidades = md.QuantidadeLocalidades();
            this.primeiraLocalidade = md.PrimeiraLocalidade();

            //deve incluir a ultima localidade no circuito
            this.ultimaLocalidade = md.UltimaLocalidade()+1;
        }

        /// <summary>
        /// Cria os circuitos da primeira geração randomicamente
        /// </summary>
        public void GerarPrimeiraGeracao()
        {
            Geracao g = new Geracao();
            g.ID = this.ListaGeracoes.Count + 1;
            GeracaoAtual = g;

            Cromossomo novoCromossomo = null;
            int tentativas = 0;

            for (int i = 1; i <= numeroCircuitos; i++)
            {
                tentativas = 0;

                novoCromossomo = this.GerarCromossomo();

                //gera um novo circuito até achar um que ainda não esteja na população
                while (this.CromossomoDuplicado(novoCromossomo))
                {
                    novoCromossomo = this.GerarCromossomo();
                   tentativas++;

                   if (tentativas == 10000)
                   {
                       //Console.WriteLine("ITEM {0} - Esgotados os circuitos. Qtd de itens na lista: {1}", this.circuitos.Count+1,this.circuitos.Count);
                   }
                }

               //Console.WriteLine("ITEM {0} - Tentativas para gerar {1}", this.circuitos.Count + 1, tentativas);
               g.AdicionarIndividuo(novoCromossomo);
            }

            this.ListaGeracoes.Add(g);
        }

        /// <summary>
        /// Gera um circuito aleatoriamente
        /// </summary>
        private Cromossomo GerarCromossomo()
        {
            Cromossomo c = new Cromossomo(this.qtdLocalidades, this.GeracaoAtual.Populacao.Count+1);
            int localidadeSorteada = 0;

            for (int i = 0; i < this.qtdLocalidades; i++)
            {
                //sorteia uma localidade que esteja entre a primeira e a última definidas na matriz de distancias
                localidadeSorteada = this.rnd.Next(this.primeiraLocalidade, this.ultimaLocalidade);

                //não pode repitir localidade no percurso
                while(c.ExisteLocalidade(localidadeSorteada))
                {
                    localidadeSorteada = rnd.Next(this.primeiraLocalidade, this.ultimaLocalidade);
                }

               c.AdicionarNodo(localidadeSorteada);
            }

            return c;
        }

        /// <summary>
        /// Verifica se o circuito já existe na população
        /// </summary>
        /// <param name="novoCromossomo">Circuito que se deseja incluir na população</param>
        /// <returns>Indica se já existe ou nao</returns>
        public bool CromossomoDuplicado(Cromossomo novoCromossomo)
        {
            bool duplicado = false;

            IList<Cromossomo> circuitos = this.GeracaoAtual.Populacao;

            foreach (Cromossomo c in circuitos)
            {
                if (c.Equals(novoCromossomo))
                {
                    duplicado = true;
                    break;
                }
            }

            return duplicado;
        }

        /// <summary>
        /// Ordena a lista de circuitos de acordo com a apitdao bruta
        /// </summary>
        public void AtualizarPopulacaoGeracaoAtual()
        {
            this.GeracaoAtual.Populacao = (from c in this.GeracaoAtual.Populacao
                                                 orderby c.AptidaoBruta descending
                                                 select c).ToList();
        }

        public void AdicionarGeracao(Geracao g)
        {
            g.ID = this.ListaGeracoes.Count + 1;
            this.ListaGeracoes.Add(g);
            this.GeracaoAtual = g;
        }

        /// <summary>
        /// Busca os circuitos da população (geração atual)
        /// </summary>
        public String ToString()
        {
            StringBuilder sb = new StringBuilder();

            IList<Cromossomo> circuitos = this.GeracaoAtual.Populacao;

            foreach (Cromossomo c in circuitos)
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
