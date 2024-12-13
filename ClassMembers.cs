using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class ClassMembers
    {
        private int yas;
        string? kilo;

          //FullyProperty
          // property hangi türden field temsil ediyorsa o türden olmalıdır.
          public int Yas
          {
               // property değer talep edildiğinde bu blok çalışır 
              get { return yas; }
              set { yas = value; }
          }
        public string Kilo
        {
            get { return kilo; }
            set { kilo = value; }
        }
    }

    /// <summary>
    /// ClassMembers2 sınıfıdır class içinde class elemanı değildir sadece class içinde tanımlanmış bir sınıftır.
    /// </summary>
    public class ClassMembers2
    {
        /// <summary>
        /// A DEĞERİNDE BİR İNT
        /// </summary>
        int a;
        public int MyProperty { get; set; }

        /// <summary>
        /// x metodu a değerini alır. 
        /// </summary>
        /// <param name="b"></param>
        public  void x(int b) { }

        public int this[int index]
        {
            get { return a; }
            set { a = value; }
        }

        // sınıfın elemanı olamaz erişmek için referansı üzerinden gitmemiz lazım.
        public class nestedClassforClassMembers2
        {
            public int nestedProperty { get; set; }
        }

        public enum OrderStatus
        {
            Completed,
            Failed,
            Suspend
        }
    }
}
