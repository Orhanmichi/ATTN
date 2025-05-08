

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W1_Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            vize1.kitab kitap1 = new vize1.kitab();
            
            kitap1.Title = "insan";
            kitap1.isim = "1293123903";
            kitap1.DisplayInfo();

            kitap1.Selamlar("orahn", 12);
            string a = kitap1.TC = "1023123123123";

            Console.WriteLine(a);

        }
    }
}