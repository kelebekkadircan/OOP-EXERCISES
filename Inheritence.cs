using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class Inheritence
    {
         
        
       
        

        // tekrar eden yapılandırmalar varsa kalıtımı alınmalıdır.
        // nesnelerin birbirinden türemesini sağlar
        // hangi yapılar kalıtım alabilir = sınıflardan alabilir ve yalnızca bir sınıftan alabilir
        // bir sınıf birden fazla sınıftan kalıtım alamaz

        // ata olan class OBJECT classıdır ve tüm sınıflar bu sınıftan kalıtım alır
        // toString Equals GetHashCode GetType gibi metotlar bu sınıftan gelir

        // Name Hiding durumunda kalıtım aldığın sınıf ile aynı imzaya sahip bir metot tanımlarsan name hiding olur
       public class A
        {
            public int X { get; set; }
            public void Y()
            {
                Console.WriteLine("Y ama a nın içi");
            }

        }
       public class B : A
        {
            public int X { get; set; }

        }

        public class C: B
        {

        }

        public class D : C
        {
            // new ile işaretlersen bilinçli yaptığını söylersin ama zorunda değilsin compiler kendisi koyuyor
            public new void Y ()
            {
                Console.WriteLine("Y ama d nin içi");
            }
        }


        public class Cars
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }
            public int Price { get; set; }
        }

        public class ElectricCars : Cars
        {
            public int BatteryLife { get; set; }
            public int EnginePower { get; set; }
        }

        public class Tesla: ElectricCars
        {
         
        }

        public class BYD : ElectricCars
        {
         
        }

        public class BMW : Cars
        {

        }
    









    }
}
