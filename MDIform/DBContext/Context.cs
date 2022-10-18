using MDIform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIform.DBContext
{
    internal class Context
    {
        //Hashset listesi özel bir listedir. Uniqe yapıya sahiptir. Aynı kayıttan iki tane olmaz.
        public static ICollection<Urun> urunler = new HashSet<Urun>();
    }
}
