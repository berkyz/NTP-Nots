using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11a
{
    /// <summary>
    /// Bu sınıf VIP Taksiler hakkında bilgi tutmak için kullanılır.
    /// </summary>
    class VipTaksi : Taksi
    {
        /// <summary>
        /// Mini Bar var ise true, yok ise false;
        /// </summary>
        public bool MiniBar { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="af"></param>
        /// <param name="bf"></param>
        /// <param name="mrk"></param>
        /// <param name="mdl"></param>
        /// <param name="my"></param>
        public VipTaksi(decimal af, decimal bf, string mrk, string mdl, int my)
            : base(af, bf, mrk, mdl, my)
        {            
        }
    }
}
