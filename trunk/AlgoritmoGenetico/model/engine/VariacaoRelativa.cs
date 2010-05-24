using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.delegates;

namespace AlgoritmoGenetico.model.engine
{
    public class VariacaoRelativa
    {
        //Fixa a variação mínima que deve existir entre as gerações
        private double variacaoMinima = 0.05;

        private event PararEvolucaoHandler FinalizarEvolucaoEvent;

        public VariacaoRelativa(TelaPrincipal principal)
        {
            /*ao verificar que a diferença relativa entre a aptidão média da população atual k e a de 5 gerações
             * atrás vario menos do que o parâmetro, dispara o evento para finalizar o processameto
            */
            this.FinalizarEvolucaoEvent += new PararEvolucaoHandler(principal.PararEvolucao);
        }

        /// <summary>
        /// Calcula a variação relativa da aptidão atual e da aptidão de 5 gerações passsadas
        /// </summary>
        /// <param name="aptidaoPopulacionalAtual">Apitdão da geração atual</param>
        /// <param name="aptidaoPopulacionalAnterior">Apitdão de 5 gerações passadas</param>
        /// <returns></returns>
        public double CalcularDiferencaRelativa(double aptidaoPopulacionalAtual, double aptidaoPopulacionalAnterior)
        {
            double variacao;
            if (aptidaoPopulacionalAtual == 0)
            {
                variacao = 0;
            }
            else
            {
                variacao = Math.Abs(aptidaoPopulacionalAtual - aptidaoPopulacionalAnterior) / aptidaoPopulacionalAtual;
                variacao = Util.ParseFormat(variacao);
            }

            if(variacao < this.variacaoMinima){
                //dispara o evento para finalizar o procesasmento do programa
                if (this.FinalizarEvolucaoEvent != null)
                {
                    this.FinalizarEvolucaoEvent(this, null);
                }
            }

            return variacao;
        }

    }
}
