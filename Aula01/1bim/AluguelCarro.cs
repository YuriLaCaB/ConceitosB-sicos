using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class AluguelCarro
    {
        public double aluguel(int totaldias, double kmini, double kmfim)
        {
            return (totaldias * 95.00) + 0.35 * (kmfim - kmini);
        }
    }
}
