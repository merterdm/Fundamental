
using MDIFormlar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIFormlar.DbContext
{
    public class Db_context
    {

        // HashSet Listesi ozel bir listedir. 
        //Uniqe yapiya sahiptir. Ayni kayittan ikinci kere almaz


        public static HashSet<Urun> Urunler = new HashSet<Urun>();
    }
}
