using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculoIMC
    {
        public double calcularIMC(double altura, double massa)
        {
            return massa / (altura * altura);
        }
    }
}
