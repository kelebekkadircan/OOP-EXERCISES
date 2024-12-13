using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public  class StaticBuilds // static yapılar
    {
        // uygulama seviyesinde işlem yapmak istiyorsam static yapılar kullanılır
        // static olmayanlar metot tetiklenince hangi noktada ise oradan erişebiliriz fakat static ise uygulamanın her yerinden ona ulaşabiliyoruz.

        // insanlar birer instance ise güneş ve ay static yapılardır her zaman erişilir.
        // insan değişirse ay etkilenmez ama ay değişirse insan etkilenir.
        

        // ram kullanımı açısından stack heap ve static yapı vardır. 
        // heap ve static global değişkenleri tutar
        // static alan heap içerisindeki high frequency heap alanında tutulur.
        // static yapılar uygulama başladığında oluşturulur ve uygulama sonlandığında silinir.
        
        static public int StaticField = 10; // static field
        public int NonStaticField = 20; // non-static field
        public static void StaticMethod() // static method
        {
            Console.WriteLine("Static Method");
        }
        public void NonStaticMethod() // non-static method
        {
            Console.WriteLine("Non-Static Method");
        }
        protected static int StaticProperty { get; set; } // static property
        public int NonStaticProperty { get; set; } // non-static property

        // overload edilebilirler fakat override edilemezler.
        // virtual ve abstract olamazlar.

    }

    public static class StaticBuilds2 // static class içerisinde sadece static metotlar olabilir. ve instance oluşturulamaz.
    {
        public static void StaticMethod2() // static method
        {
            Console.WriteLine("Static Method 2");
        }
        
        // hata vericektir.
        //public  void NonStaticMethod2() {
        //    Console.WriteLine("Non-Static Method 2");
        //}
    }

    public class StaticBuilds3  : StaticBuilds
    {
        public static void StaticMethod3() // static method
        {
            Console.WriteLine("Static Method 3");
        }
        public StaticBuilds3()
        {
            // burada protected veriyi inherit ettik ve değiştirebiliyoruz.
            StaticProperty = 10;
            Console.WriteLine(StaticProperty);
        }


    }

}
