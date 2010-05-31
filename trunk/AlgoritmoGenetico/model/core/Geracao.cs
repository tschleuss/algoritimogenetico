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
        public double AptidaoPopMedia { get; set; }
        public IList<Cromossomo> Populacao { get; set; }

        public Geracao()
        {
            this.Populacao = new List<Cromossomo>();
            this.AptidaoPopulacional = 0;
        }

        /// <summary>
        /// Adiciona um circuito à geração
        /// </summary>
        /// <param name="novoCromossomo">Novo circuito</param>
        public void AdicionarIndividuo(Cromossomo novoCromossomo){
            this.Populacao.Add(novoCromossomo);
            novoCromossomo.GeracaoID = this.ID;
        }

    }
}
