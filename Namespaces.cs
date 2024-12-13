using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ikisinin içerisinde de x metodu var. hangisini çağıracağını belirtmek için alias kullanılır.
using m1 = MyNameSpace;
using m2 = MyNameSpace2;

namespace OOP_EXERCISES
{
   public  class Namespaces
    {
    }
}

namespace MyNameSpace
{
    public class MyNameSpaceClass
    {
        public void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }

      
    }

   
    
}


namespace MyNameSpace2
{
    public class MyNameSpaceClass2
    {
        public void MyMethod()
        {
            Console.WriteLine("MyMethod2");
        }

        public static void X()
        {
            Console.WriteLine("x");
        }
    }
    

}


// global operatörü 
// .csproj dosyasına gidip itemgroup içerisine <using include ""/> şeklinde ekleyebiliriz.
// implicit using disabled yapılırsa sadece eklediğimiz usingler çalışır.
// :: operatörü ile namespace içerisindeki classlara erişebiliriz. global keywordüdür ve global namespace'i temsil eder.
// global::MyNameSpace.MyNameSpaceClass m1 = new() şeklinde kullanılır. // refere verir ve yeni nesne üretir