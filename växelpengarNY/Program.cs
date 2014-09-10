using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace växelpengarNY
{
    class Program
    {
        static void Main(string[] args)
        {

            // deklarera variabler
            double totalAmount;             //totalsumman
            double roundingOfAmount;        // avrundning 
            uint requiredAmount;            // belopp som krävs
            uint cash;                      // betalat/erhållet belopp
            uint change;                    // växel
            int result;


            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumman:   ");  //eftefråga totalsumman
                    totalAmount = double.Parse(Console.ReadLine());
                    break;
                    if (totalAmount < 0.50)
                    {
                        Console.WriteLine("totalsumman är inte korrekt");

                    }
                }
                catch
                {

                    Console.WriteLine("Du behöver skriva in en summa i form av siffor");

                }
            }

            while (true)
            {
                try
                {

                    Console.Write("Ange erhållet belopp:  "); //efterfråga erhållet belopp
                    cash = uint.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Du behöver skriva in en summa i form av siffor");

                }
            }




            // bestäm öresavrundningen
            requiredAmount = (uint)Math.Round(totalAmount);
            roundingOfAmount = totalAmount - requiredAmount;
            // beräkna växel som ska tillbaka
            change = cash - requiredAmount;

            // Kvitto
            Console.WriteLine("KVITTO");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Totalt \t\t {0:c}", totalAmount);
            Console.WriteLine("Öresavrundning \t {0:c}", roundingOfAmount);
            Console.WriteLine("Att betala \t {0:c}", requiredAmount);
            Console.WriteLine("Kontant \t {0:c}", cash);
            Console.WriteLine("Växel \t\t {0:c}", change);
            Console.WriteLine("----------------------------------");

            //om växeln är ... eller mer, presentera antalet ...-lappar
            // ta  bort de eventuella 500-lapparna ur växelsumman så att resten av växeln återstår

            if (change >= 500)
            {

                result = (int)change / 500;
                Console.WriteLine("antal 500 lappar = {0,3}", result);

                change = change % 500;


                if (change >= 100)
                {
                    result = (int)change / 100;
                    Console.WriteLine("antal 100 lappar= {0,3}", result);

                    change = change % 100;

                }

                if (change >= 50)
                {
                    result = (int)change / 50;
                    Console.WriteLine("antal 50 lappar= {0,3}", result);

                    change = change % 50;

                }

                if (change >= 20)
                {
                    result = (int)change / 20;
                    Console.WriteLine("antal 20 lappar= {0,3}", result);

                    change = change % 20;

                }

                if (change >= 10)
                {
                    result = (int)change / 10;
                    Console.WriteLine("antal 10-kronor= {0,3}", result);

                    change = change % 10;

                }

                if (change >= 5)
                {
                    result = (int)change / 5;
                    Console.WriteLine("antal 5-kronor= {0,3}", result);

                    change = change % 5;

                }

                if (change >= 1)
                {
                    result = (int)change / 1;
                    Console.WriteLine("antal 1-kronor= {0,3}", result);

                    change = change % 1;

                }



            
        }
    }
}
