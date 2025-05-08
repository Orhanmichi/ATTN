
using Ornek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizeçalışması
{
    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //B.B_static();
            //b.B_nonstatic();
            ABS obje = new ABS();
            obje.tc_ = "123456789123oe0";

            Console.WriteLine(obje.tc_);

            DateTime date = (19); (11); (2023);

        }

    }
    class ABS
    {
        private string tc;
        public string tc_
        {
            get
            {
                return tc+"*******";
            }

            set
            {

                int count = 0;
                string a = value.ToString();
                if (a.Length == 11)
                {
                    
                    for (int i = 0; i < a.Length; i++)
                    {
                        
                        bool check = char.IsNumber(a[i]);
                        if (check)
                        {
                            count++;
                            
                        }
                    }
                    if (count == 11)
                    {
                        tc = a.Substring(0,4);
                    }

                }
                else
                {
                    Console.WriteLine("incorrect TC ");
                    
                    
                    
                }

            }
        }
    }
}
