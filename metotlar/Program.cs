using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            urun urun1 = new urun();
            urun1.Adı = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elma";

            urun urun2 = new urun();
            urun2.Adı = "karpuz";
            urun2.Fiyati = 35;
            urun2.Aciklama = "diyarbakır karpuzu";

            urun[] urunler = new urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");
                
            }

            Console.WriteLine("-----------metolar----------------");
            SepetManager sepetManager= new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.ekle2("armut", " yeşil armut", 12,10);
            sepetManager.ekle2("elma", " yeşil elma", 12,9);
            sepetManager.ekle2("karpuz", " adana karpuzu", 12,8);

            Console.ReadLine();
        }
      
    }
   
}
// tekrar tekrar kullanmalarda  metotlar kulanılır.