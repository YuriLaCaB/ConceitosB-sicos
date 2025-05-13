using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class FatorialDosNumeros
    {
        public int FatorialNum(int num1)
        {
            int num2 = num1;
            for (int i = 1; i < num1; i++)
            {
                num2 = num2 * i;
            }
            return num2;
        }
    }
}
