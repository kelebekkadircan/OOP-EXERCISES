using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class Records
    {
        // bu özellik sadece nesnenin ilk yaratılış anında propuna değer atanmakta ve daha sonra değiştirilememektedir.
        // iş gereği runtime da değişmemesi gereken değerler için kullanılır.

        // set atamadım readonly yaptım.
        public string Name { get; } = "can";

        // init - only properties
        // init ile sadece nesne oluşturulurken değer atanabilir. daha sonra değiştirilemez.
        public string Surname { get; init; } = "kelebek";


        // readonly kullanımında set hata verir ama init orada set görevi görür
        readonly int a;
        public int A
        {
            get { return a; }
            // set { a = value; } // readonly olduğu için hata verir.
            init { a = value; }
        }

        // record bir objenin bütün olarak sabit kalmasını sağlar ve güvence altına alır.
        // nesne ön plandaysa bu class değerleri ön plandaysa recorddur.



        public record MyRecord
        {
            public int MyProperty { get; set; }
        }
        public class MyClass
        {
            public int MyProperty { get; set; }

        }


    }
}
