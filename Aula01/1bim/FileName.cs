using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    internal class FileName
    {
        public double Aposentar(double idade, double contribuicao, double media)
        {
            double idadeMin = 62;
            double contribMin = 15;
            double extra, perc;
            double valor;
            if (idade >= idadeMin && contribuicao >= contribMin)
            {
                extra = contribuicao - contribMin;
                perc = 60 + (extra * 2);
                if (perc > 100) perc = 100;

                valor = media * (perc / 100);
                return valor;
            }
            else
            {
                return 0;
            }
        }
    }
}