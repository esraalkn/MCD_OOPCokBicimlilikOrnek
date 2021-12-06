using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    class Banka
    {
        public string BankaAdi { get; set; }
        
        private decimal _alisveristutari=0;

        public decimal AlisverisTutari { get; set; }

        public void BilgileriAl()
        {
            Console.WriteLine(BankaAdi + " bankasına hoşgeldiniz...");
            Console.WriteLine("Alışveriş Tutarını giriniz: ");

            _alisveristutari = Convert.ToDecimal(Console.ReadLine());
            if (_alisveristutari>0)
            {
                AlisverisTutari = _alisveristutari;
            }
            else
            {
                throw new Exception("Tutar Sıfırdan büyük olmalıdır.");
            }
        }

        public virtual void IndirimOraninaGoreIndirim()
        {
            AlisverisTutari -= AlisverisTutari * 0.20m;
            Console.WriteLine("%20 indirim uygulandı...");
            Console.WriteLine("Ödenecek tutar" + AlisverisTutari);
        }
  
        

    }
}
