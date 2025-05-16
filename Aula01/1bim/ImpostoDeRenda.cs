using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class ImpostoDeRenda
    {
        public double Imposto(int dependente, double renda)
        {
            renda -= dependente * 189.59;
            if (renda <= 1903.98)
            {
                return 0;
            }
            else if (renda <= 2826.65)
            {
                return renda * 0.075 - 142.80;
            }
            else if (renda <= 3751.05)
            {
                return renda * 0.15 - 354.80;
            }
            else if (renda <= 4664.68)
            {
                return renda * 0.225 - 636.13;
            }
            else
            {
                return renda * 0.275 - 896.36;
            }
        }
    }
}
