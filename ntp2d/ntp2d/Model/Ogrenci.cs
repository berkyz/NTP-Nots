using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2d.Model
{
    
    class Ogrenci
    {
        [Key, NotNull]
        public string Numara { get; set; }

        public string Ad { get; set; }
        // [ForeignKey ]
        public string BolumKodu { get; set; }
    }
}
