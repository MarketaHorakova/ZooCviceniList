using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniZooList
{
    public class ZOO
    {
        private List<Zvire> seznamZvirat;

        public ZOO()
        {
            seznamZvirat = new List<Zvire>();
        }

        public void PridatZvire()
        {
            Console.WriteLine("ZADÁNÍ NOVÉHO ZVÍŘETE:");
            Console.WriteLine("Zadej typ zvirete:");
            string typ = Console.ReadLine();
            Console.WriteLine("Zadej jmeno zvirete:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadej věk zvirete:");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej vahu zvirete:");
            double vaha = double.Parse(Console.ReadLine());

            Zvire objektZvire = new Zvire(typ, jmeno, vek, vaha);
            seznamZvirat.Add(objektZvire);
        }

        public void VypisZvirat()
        {
            Console.WriteLine("VÝPIS ZVÍŘAT:");
            foreach (Zvire i  in seznamZvirat) 
            {
                i.VypisInformaci();
            }
        }

        public void VymazZvirete()
        {
            Console.WriteLine("Ktere zvire smazat:");
            int pocetZvirat = seznamZvirat.Count;
            Console.Write("R0 Nic nemazat\n");
            for (int i = 0; i < pocetZvirat; i++)
            {
                Console.Write($"R{i+1} {seznamZvirat[i].TypZvirete}\n");
            }
            Console.WriteLine("Poradove cislo pro smazani R_");
            int removeIndex = int.Parse(Console.ReadLine());

            if (( removeIndex >= 0 ) && ( removeIndex < pocetZvirat))
            {
                seznamZvirat.RemoveAt(removeIndex);
            }
            else { Console.WriteLine("Zadal jsi spatnou pozici, zvire nebylo smazano."); }

            VypisZvirat();
          
        }

        public void UpravaZvirete ()
        {
            Console.WriteLine("Ktere zvire upravit:");
            int pocetZvirat = seznamZvirat.Count;
            for (int i = 0; i < pocetZvirat; i++)
            {
                Console.Write($"C{i} {seznamZvirat[i].TypZvirete}\n");
            }
            Console.WriteLine("Poradove cislo pro upravu zvirete C_");
            int correctionIndex = int.Parse(Console.ReadLine());
            int correctionAtributeIndex = 0;

            if ((correctionIndex >= 0) && (correctionIndex < pocetZvirat))
            {
                Console.WriteLine($"1.Typ zvirete {seznamZvirat[correctionIndex].TypZvirete}");
                Console.WriteLine($"2. Jmeno zvirete {seznamZvirat[correctionIndex].JmenoZvirete}");
                Console.WriteLine($"3. Vek zvirete{seznamZvirat[correctionIndex].VekZvirete}");
                Console.WriteLine($"4. Vaha zvirete{seznamZvirat[correctionIndex].VahaZvirete}");

                correctionAtributeIndex = int.Parse(Console.ReadLine());

            }
            else { Console.WriteLine("Zadal jsi spatnou pozici, zvire nebude upraveno."); }

            switch (correctionAtributeIndex)
            {
                case 1:
                    Console.WriteLine("Napis novy typ zvirete:");
                    seznamZvirat[correctionIndex].TypZvirete = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Napis nove jmeno zvirete:");
                    seznamZvirat[correctionIndex].JmenoZvirete = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Napis novy vek zvirete:");
                    seznamZvirat[correctionIndex].VekZvirete = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Napis novou vahu zvirete:");
                    seznamZvirat[correctionIndex].VahaZvirete = int.Parse(Console.ReadLine());
                    break;
            }

            VypisZvirat();
            
        }
    }
}
