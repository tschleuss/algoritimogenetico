﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;

namespace AlgoritmoGenetico.model
{
    /// <summary>
    /// Representa o circuito entre as localidades, pasando apenas uma vez por cada uma
    /// </summary>
    public class Cromossomo
    {

        public int ComprimentoCircuito { get; set; }
        public double AptidaoBruta { get; set; }
        public double ProbabSelecao { get; set; }
        public double IntervaloInicio { get; set; }
        public double IntervaloFim { get; set; }
        public int ID { get; set; }
        public int GeracaoID { get; set; }

        private IList<int> circuito;
        public IList<int> Circuito
        {
            get { return circuito; }
            set { circuito = value; }
        }


        public String CircuitoString
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("0-");

                for (int i = 0; i < circuito.Count; i++)
                {
                    sb.Append(circuito[i]);


                    if (i < circuito.Count - 1)
                    {
                        sb.Append("-");
                    }
                }

                sb.Append("-0");

                return sb.ToString();
            }
        }


        //armazena a mutação do cromossomo
        public int[] GenesMutados;
        public void GerarMutacao(int indiceGene1, int indiceGene2)
        {

            this.GenesMutados = new int[2];

            this.GenesMutados[0] = this.circuito[indiceGene1];
            this.GenesMutados[1] = this.circuito[indiceGene2];

            //troca os dois genes
            this.circuito[indiceGene2] = this.GenesMutados[0];
            this.circuito[indiceGene1] = this.GenesMutados[1];
        }

        public String GenesMutadosString
        {
            get
            {
                if (this.GenesMutados != null)
                {
                    return String.Format("Trocados: {0} e {1}", this.GenesMutados[0], this.GenesMutados[1]);
                }
                else
                {
                    return "-";
                }
            }
        }


        public String IntervaloTotal
        {
            get
            {
                return String.Format("[{0} - {1}]", IntervaloInicio, IntervaloFim);
            }
        }

        public int Tamanho
        {
            get;
            set;
        }

        /// <param name="tamanho">Quantidade máxima de localidades</param>
        public Cromossomo(int tamanho, int id)
        {
            this.circuito = new List<int>();
            this.Tamanho = tamanho;
            this.ID = id;
            this.ComprimentoCircuito = 0;
            this.AptidaoBruta = 0;
            this.ProbabSelecao = 0;
            this.IntervaloInicio = 0;
            this.IntervaloFim = 0;
        }

        /// <summary>
        /// Verifica se a localidade já existe no circuito
        /// </summary>
        /// <param name="localidade">Localidade que se verificar</param>
        /// <returns>Indica se a localidade já está no circuito ou não</returns>
        public bool ExisteLocalidade(int localidade)
        {
            return this.circuito.Contains(localidade);
        }

        /// <summary>
        /// Adiciona um valor ao circuito
        /// </summary>
        /// <param name="valorNodo">Nova localidade do circuito</param>
        /// <returns>Indica se o nodo foi realemten adicionado ao circuito</returns>
        public bool AdicionarNodo(int valorNodo)
        {
            if (this.circuito.Count <= this.Tamanho)
            {
                this.circuito.Add(valorNodo);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna o valor do nodo do cromossomo na posição passada como parâmetro
        /// </summary>
        /// <param name="index">Posição do nodo</param>
        /// <returns>Valor do nodo</returns>
        public int BuscarNodo(int index)
        {
            return this.circuito[index];
        }

        /// <summary>
        /// Cálcula o comprimento total do percurso
        /// </summary>
        /// <returns>Comprimento total</returns>
        public int CalcularComprimentoCircuito(MatrizDistancias md)
        {
            if(this.ComprimentoCircuito == 0){

                int destino = 0;
                int origem = 0;

                foreach (int localidade in this.circuito)
                {
                    origem = destino;

                    if (origem != 0)
                    {
                        destino = localidade;
                        this.ComprimentoCircuito += md.BuscarDistancia(origem, destino);
                    }
                    else
                    {
                        destino = localidade;
                    }
                }

                //de 0 até o primeira localidade
                this.ComprimentoCircuito += md.BuscarDistancia(0, this.circuito.First());

                //da última localidade até 0
                this.ComprimentoCircuito += md.BuscarDistancia(this.circuito.Last(), 0);

            }

            return this.ComprimentoCircuito;
        }

        /// <summary>
        /// Compara dois circuitos para verifica se são iguais
        /// </summary>
        /// <param name="c">Cromossomo que será comparado</param>
        /// <returns>Indica se os cromossomos são iguais ou não</returns>
        public bool Equals(Cromossomo c)
        {
            bool igual = true;

            for (int i = 0; i < this.Tamanho; i++)
            {
                if (this.BuscarNodo(i) != c.BuscarNodo(i))
                {
                    igual = false;
                    break;
                }
            }

            return igual;
        } 

    }
}
