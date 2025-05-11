using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculoDesconto
    {
        public double calcDesconto(double precoIni, double desconto)
        {
            return precoIni - precoIni * desconto/100;
        }
    }
}
