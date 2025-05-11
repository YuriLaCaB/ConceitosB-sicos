using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculoAumento
    {
        public double calcularAumento(double salario, double aumento)
        {
            return salario+salario*(aumento/100);
        } 
    }
}
