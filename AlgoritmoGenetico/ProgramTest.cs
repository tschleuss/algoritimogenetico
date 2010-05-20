using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoritmoGenetico.model.core;
using AlgoritmoGenetico.model.engine;
using AlgoritmoGenetico.model;

namespace AlgoritmoGenetico
{
    public class ProgramTest
    {

        public void Testar()
        {
            MatrizDistancias md = new MatrizDistancias();
            md.CarregarMatriz();

            Console.WriteLine("Matriz de distancias:");
            Console.WriteLine(md.ToString());

            Populacao p = new Populacao(md);
            p.GerarPopulacao();

            Console.WriteLine("Circuitos gerados randomicamente:");
            Console.WriteLine(p.ToString());

            Aptidao ap = new Aptidao(md);
            ap.CalcularAptidaoBruta(p.GeracaoAtual.Populacao);
            ap.CalcularAptidaoPopulacional(p.GeracaoAtual);

            //após calcular a aptidaão bruta, atualiza a lista atual, ordenando pela aptidão bruta calculada
            p.AtualizarPopulacaoGeracaoAtual();

            Console.WriteLine("Circuitos ordenados por aptidao:");
            Console.WriteLine(p.ToString());

            new ProbabilidadeSelecao().CalcularProbabilidade(p.GeracaoAtual);

        }
    }
}
