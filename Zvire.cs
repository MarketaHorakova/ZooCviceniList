using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniZooList
{
    public class Zvire
    {
        public string TypZvirete { get; set; }
        public string JmenoZvirete { get; set; }
        public int VekZvirete { get; set; }
        public double VahaZvirete { get; set; }

        public Zvire (string typZvirete, string jmenoZvirete, int vekZvirete, double vahaZvirete)
        {
            TypZvirete = typZvirete;
            JmenoZvirete = jmenoZvirete;
            VekZvirete = vekZvirete;
            VahaZvirete = vahaZvirete;
        }

        public void VypisInformaci ()
        { 
            Console.WriteLine($"{JmenoZvirete}, {TypZvirete}, {VekZvirete} let, {VahaZvirete} kg."); 
        }

        
    }
}
