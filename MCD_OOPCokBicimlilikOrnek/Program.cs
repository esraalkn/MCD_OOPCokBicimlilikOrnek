using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polimorphism 

            Console.WriteLine("Banka seçiniz A/B : ");
            ConsoleKeyInfo secim;
            secim = Console.ReadKey();
            
            if (secim.Key==ConsoleKey.A)
            {
                ABankasi A1 = new ABankasi();
                A1.BilgileriAl();
                A1.IndirimOraninaGoreIndirim();
            }
            else if (secim.Key == ConsoleKey.B)
            {
                BBankasi B1 = new BBankasi();
                B1.BilgileriAl();
                B1.IndirimOraninaGoreIndirim();

            }
            Console.ReadKey();
        }
    }
}
