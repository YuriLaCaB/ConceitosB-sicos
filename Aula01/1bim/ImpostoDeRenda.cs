using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class ImpostoDeRenda
    {
        public double Imposto(int valor,int renda)
        {
            double imposto;
            imposto = renda * (valor * 0.01);
            return imposto;
        }
    }
}
