using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp2g
{
    public interface IOuter: IComparable
    {
        void OuterMethod();

        // İç içe interface tanımı
        public interface IInner
        {
            void InnerMethod();
        }
    }
}
