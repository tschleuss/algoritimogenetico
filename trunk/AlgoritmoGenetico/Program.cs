using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace AlgoritmoGenetico
{
    public static class Program
    {
        /// <summary> 
        /*Descrição do algoritmo:
         * 
         * 
         *               INICIALIZAÇÃO DA POPULAÇÃO
         * |-------------------->     |
         * |  CÁLCULO DA APTIDÃO DOS INDIVÍDUOS DA POPULAÇÃO
         * |                          |
         * |                SOLUÇÃO SATISFATÓRIA?   --SIM-->    FIM DO ALGORITMO
         * |                          |
         * |                       SELEÇÃO
         * |                          |
         * |                      CRUZAMENTO
         * |                          |
         * |                       MUTAÇÃO
         * |                          |
         * |--------------------------|
         */
        /// </summary>
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
            

            ProgramTest p = new ProgramTest();
            p.Testar();

            Console.ReadLine();
        }
    }
}
