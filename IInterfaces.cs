using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP_EXERCISES.IInterfaces;

namespace OOP_EXERCISES
{
    public interface IInterfaces
    {
        // abstract class ile farkı içerisindeki imzalara odaklanmasıdır.
        //  can do ilişkisi vardır.
        //  bir sınıf birden fazla interface'i implemente edebilir.
        // classlarda metot üretmeden önce gidip interface de imza oluşturup sonra classa gidip implemente ediyoruz.
        // referans türlü değikenlerdir yani bir referanstırlar
        // namespace içeirisinde dışında neredeyse her yerde kullanılabilirler.
        // metot içinde tanımlanamazlar.
        void MyMethodIinterface();

        // ikisi de aynı işi yapar. 
       public interface IMyInterface
        {
            void MyMethodMyInterface();
        }
        abstract class MyAbstractClass 
        {
            public abstract void MyMethod();
        }

        // kalıtım değil implementasyondur.
        // override durumu söz konusu değildir.
        class InterfaceMyClass : IMyInterface
        {
            public void MyMethod()
            {
                Console.WriteLine("MyMethod");
            }

            public void MyMethodMyInterface()
            {
                throw new NotImplementedException();
            }
        }

        class IInterfaceMyClass2 : MyAbstractClass
        {
            // OVERRIDE EDILMEK ZORUNDA
            public override void MyMethod()
            {
                throw new NotImplementedException();
            }
        }


    }

    // birden fazla interface implemente edilebilir.
  // kendi aralarında kalıtım alabilirler
    class denemeınterface : IInterfaces, IMyInterface
    {
       

        public void MyMethodIinterface()
        {
            throw new NotImplementedException();
        }

        public void MyMethodMyInterface()
        {
            throw new NotImplementedException();
        }
    }



    // interfaceler birden fazla interfaceden kalıtım alabilirler

    interface IMyInterfaceA : IInterfaces
    {
        void MyMethodA();
        
    }
    interface IMyInterfaceB : IMyInterface
    {
        void MyMethodB();

    }
    interface IMyInterfaceC
    {
        void MyMethodC();
        
    } 
    // BU İMPLEMENTASYON DEĞİL KALITIMDIR.
    // INTERFACELER BİRDEN FAZLA INTERFACEDEN KALITIM ALABİLİRLER
    interface IMyInterfaceD : IMyInterfaceA, IMyInterfaceB, IMyInterfaceC
    {
        
    }


    class denemeınterface2 : IMyInterfaceD
    {
        public void MyMethod()
        {
            throw new NotImplementedException();
        }

        public void MyMethodA()
        {
            throw new NotImplementedException();
        }

        public void MyMethodB()
        {
            throw new NotImplementedException();
        }

        public void MyMethodC()
        {
            throw new NotImplementedException();
        }

        public void MyMethodIinterface()
        {
            throw new NotImplementedException();
        }

        public void MyMethodMyInterface()
        {
            throw new NotImplementedException();
        }
    }
}
