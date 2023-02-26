using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class SepetManager
    {
        public void Ekle(urun urun)
        {
            Console.WriteLine("sepete kelendi :  "+ urun.Adı);
        }
        public void ekle2(string urunadi,string aciklama,double fiyat , int stokadedi)
        {
            Console.WriteLine("tebrikler . sepete eklendi  :" + urunadi);
        }
    }
}
