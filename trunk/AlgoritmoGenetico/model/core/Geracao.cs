using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico.model.core
{
    public class Geracao
    {
        public int ID {get; set;}
        public double AptidaoPopulacional { get; set; }
        public IList<Cromossomo> Populacao { get; set; }

        public Geracao()
        {
            this.Populacao = new List<Cromossomo>();
            this.AptidaoPopulacional = 0;
        }

        public void AdicionarIndividuo(Cromossomo c){
            this.Populacao.Add(c);
        }

    }
}
