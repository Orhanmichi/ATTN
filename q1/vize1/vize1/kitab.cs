using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize1
{
    public class kitab
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string isim;
        private string tc;
        public string TC
        {
            get
            {
                return tc;
            }
            set
            {
                tc = value;
            }
        }
        public kitab()
        {
            Console.WriteLine("yapıcı methot calıstı");
            Author = "Orhna";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\"{Title}\" by {Author},,,{isim}");
        }
        public void Selamlar(string a, int b)
        {
            Console.WriteLine(a + b);
        }

    }
}
