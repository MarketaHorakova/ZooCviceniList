using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniZooList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZOO objektZoo = new ZOO();
            int userChoice = 0;

            do
            {
                Console.WriteLine("Správa ZOO\nMožné akce:\n" +
                "1. Přidat nové zvíře\n" +
                "2. Vypsat informace o všech zvířatech\n" +
                "3. Vymaz zvirete z evidence\n" +
                "4. Uprava zvirete v evidenci\n" +
                "5. Ukonči program");
            
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        objektZoo.PridatZvire();
                        break;
                    case 2:
                        objektZoo.VypisZvirat();
                        break;
                    case 3:
                        objektZoo.VymazZvirete();
                        break;
                    case 4:
                        objektZoo.UpravaZvirete();
                        break;

                }

            } while (userChoice != 5);
            

        }
    }
}
