using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public struct MyStruct
    {
        // değer türünde bir veri tipi oluşturmak için struct kullanılır.
        // class ile referans struct ile de değer türünde bir veri tipi oluşturulur. 
        // int boolean vs hepsi struct yapılanmasıdır
        // classlara nazaran daha ufak boyutlu veriler oluşturmak için kullanılır.

        // belleğin stack kısmında saklanacaktır . 
        public string Z;

        public int X { get; set; }
        public int Y { get; set; }

        // class ile farkı tutulduğu yerin stack olması sayesinde daha hızlı ve performanslı olacaktır.
        // struct kalıtımı desteklemez sadece interface implemente edilebilir.
        // structlar nullable türleri destekler fakat varsayılan olarak nullable değillerdir.
        // MyStruct myStruct = null; // bu şekilde kullanılamaz.
        // MyStruct? myStruct = null; // bu şekilde kullanılabilir. nullable operatörü ile kullanılabilir.

        // maliyet Class > Record > Struct ve performans tam tersi

        public int MyMethod()
        {
            //Console.WriteLine(X + Y);
            return X + Y;
        }

        public void NewStruct()
        {
            this = new MyStruct();
        }


    }
    


    
}
