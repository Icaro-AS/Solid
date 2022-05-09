﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OCP.SolucaoComHeranca
{
    internal class ValorPagamentoAntecipado : Fatura
    {
        public override decimal GerarFaturaDescontoOuEncargo(decimal valor)
        { 
            return valor - 100;
        }
    }
}
