using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ders11a
{
	// Dinamik
    class Araba: IArac // Temel Sınıf
    {
		private string marka; // Alan, private

		public string Marka // Özellik, public
		{
			get { return marka; }
			set { marka = value; }
		}

		private int modelYili;

		public int ModelYili
		{
			get { return modelYili; }
			set
			{
				if(value >= 1800)
					modelYili = value; 
			}
		}
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private char vites;

		public char Vites
		{
			get { return vites; }
			set 
			{
				if("DRN12345P".Contains(value))
					vites = value; 
			}
		}

		private int hiz;

		public int Hiz
		{
			get { return hiz; }
			set
			{
				if(value >=0)
					hiz = value;
			}
		}

        //     public Araba()
        //     {
        //marka = "İsimsiz";
        //model = "İsimsiz";
        //modelYili = 1800;
        //     }
		// Kurucu
        public Araba(string mrk="İsimsiz", string mdl="İsimsiz", int mdlY=1800)
        {
            marka = mrk;
			model = mdl;
			modelYili = mdlY;
			hiz = 0;
        }

		public void FrenYap()
		{
			hiz = 0;
            Console.WriteLine("Araba durdu.");
		}

        public int Yas(int dy)
        {
            return DateTime.Now.Year - dy;
        }
    }
}
