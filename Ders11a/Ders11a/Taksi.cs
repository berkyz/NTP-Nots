using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11a
{
    // Türemiş dinamik sınıf
   /* sealed */  class Taksi : Araba, IComparable
    {
        public static int Sayisi=0;
        public Taksi(decimal af, decimal bf, string mrk, string mdl, int mdly)
            :base(mrk, mdl, mdly)
        {
            acilisFiyati = af;
            birimFiyat = bf;
            Sayisi++;
        }

        public decimal UcretHesapla(double yol)
		{
			return acilisFiyati + birimFiyat * Convert.ToDecimal(yol);
		}

        public static decimal Ucret(decimal af, decimal bf, decimal yol)
        {
            return af + bf * yol;
        }

		public override string ToString()
		{
			return $"{Marka} {Model} marka {ModelYili} model taksi açılış fiyatı {acilisFiyati} ₺ ve birim fiyatı {BirimFiyat} ₺/km'dir."+
                "\r\n"+Global.TamYol;
		}

        public int CompareTo(object? othr)
        {
            var other = othr as Taksi;
            if (other == null) 
            {
                if (other.AcilisFiyat == AcilisFiyat && other.BirimFiyat == BirimFiyat && other.Marka == Marka && other.Model == Model && other.ModelYili == ModelYili)
                    return 0;
            }
            return -1;
        }

        private decimal acilisFiyati;

        public decimal AcilisFiyat
        {
            get { return acilisFiyati; }
            set
            {
                if (value > 0)
                    acilisFiyati = value;
            }
        }

        private decimal birimFiyat;

        public decimal BirimFiyat
        {
            get { return birimFiyat; }
            set { birimFiyat = value; }
        }

    }
}
