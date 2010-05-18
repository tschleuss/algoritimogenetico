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
            MatrizDistancias m = new MatrizDistancias();
            m.CarregarMatriz();

            Console.WriteLine("Matriz de distancias:");
            Console.WriteLine(m.ToString());

            Populacao p = new Populacao();
            p.GerarPopulacao(m);

            Console.WriteLine("Circuitos gerados randomicamente:");
            Console.WriteLine(p.ToString());

            Console.WriteLine("Tamanho dos percursos:");
            int i = 1;
            foreach(Cromossomo c in p.Circuitos){
                Console.WriteLine(String.Format("{0} - {1}", i, c.ComprimentoCircuito(m)));
                i++;
            }
        }
    }
}
