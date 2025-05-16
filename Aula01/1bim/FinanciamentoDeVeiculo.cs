using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class FinanciamentoDeVeiculo
    {
        public double FinanciamentoDeAutomovel(double financiado1, int parcelas1, float juros1)
        {
            float i = juros1 / 100;
            double totalPagar = financiado1 + (financiado1 * i * parcelas1);
            double parcela = totalPagar / parcelas1;
            return parcela;
        }
    }
}
