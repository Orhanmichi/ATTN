using System;

namespace Ornek
{
    class A
    {

        private int öğrenciNo { get; set; }
        private string isim { get; set; }

        public A(int öğrenciNo, string isim)
        {
            this.öğrenciNo = öğrenciNo;
            this.isim = isim;
        }

        private void OgrBilgiGöster()
        {
            Console.WriteLine(öğrenciNo+"ZZZOOORTT  "+isim);
        }
        public void Göster()
        {
            OgrBilgiGöster();
        }





        //    public static int count { get; set; }
        //    public static int number { get; set; }

        //    public A()
        //    {
        //        count++;
        //    }
        //    public static void SayCount()
        //    {

        //        Console.WriteLine(count);
        //        Console.WriteLine(number);
        //    }



        //private static decimal tc;
        //public static decimal sayi1
        //{
        //    get
        //    {
        //        return tc;
        //    }
        //    set
        //    {
        //        tc = value;
        //    }
        //}
        //private static void TcYazdır()
        //{
        //    Console.WriteLine(tc);
        //}
        //public string metod { get; set; }


    }
    /*public class B
    {
        public static void B_static()
        {
            A a = new A();
            Console.WriteLine("B statik metod");
            A.A_static();
            a.A_nonstatic1();
            a.A_nonstatic2();

        }
        public void B_nonstatic()
        {
            Console.WriteLine("B nonstatik");
            A a = new A();
            A.A_static();
            a.A_nonstatic1();
            a.A_nonstatic2();
        }
    }*/


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Static metodu çağır
    //        B.StaticMetodB();

    //        Console.WriteLine();

    //        // Non-static metodu çağırmak için B nesnesi
    //        B b = new B();
    //        b.NonStaticMetodB();
    //    }
    //}
}
