using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfLigueConsole.Classes.TechnicalClasses
{
    public class GolfComparator: IComparer<Club>
    {
        public int Compare(Club x, Club y)
        {
            if (x.Licencie > y.Licencie)
            {
                return 1;
            }
            else
            {
                if (x.Licencie < y.Licencie)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
