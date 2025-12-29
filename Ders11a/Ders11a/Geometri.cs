using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11a
{
    class Geometri
    {
        public const double Pi = 3.1415927;
        public static double DaireninAlani(double yaricap)
        {
            return Pi*yaricap*yaricap;
        }
        public static double DaireninCevresi(double yaricap)
        {
            return 2 * Pi * yaricap;
        }
        public static double KareninAlani(double kenar)
        {
            return kenar * kenar;
        }

        /// <summary>
        /// Bir kenar uzunluğu argüman olarak girilen karenin çevresini hesaplar.
        /// </summary>
        /// <param name="kenar">Karenin bir kenar uzunluğu</param>
        /// <returns>Kenar uzunluğu kenar parametresi ile bildirilen karenin çevresini döndürür.</returns>
        public static double KareninCevresi(double kenar)
        {
            return 4 * kenar;
        }
    }
}
