using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoritmoGenetico.model.delegates
{
    public delegate void TabGeracaoAvancarGeracaoHandler(object sender, EventArgs e);
    public delegate void PararEvolucaoHandler(object sender, EventArgs e);
}