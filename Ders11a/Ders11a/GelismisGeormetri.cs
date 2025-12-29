using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11a
{
    public static class GelismisGeormetri
    {
        public static double DaireninAlani(double r)
        {
            return Geometri.DaireninAlani(r);
        }

        public static double YamugunAlani(double t, double u, double y)
        {
            return (t + u) * y / 2;
        }
    }
}
