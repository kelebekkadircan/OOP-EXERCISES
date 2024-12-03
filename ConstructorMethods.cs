using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class ConstructorMethods
    {
        // özel bir sınıf elemanıdır  aman aman değil bir tık farklıdır 
        // metodun adı sınıfın adı ile aynı ise bu constructerdır 
        // public olmalı ve geri dönüş değeri olmamalıdır
        public ConstructorMethods()
        {
            Console.WriteLine("1 . Constructrator methodu Çalıştı");
        }

        public ConstructorMethods(int a) : this()
        {
            Console.WriteLine($"2 . Constructrator methodu Çalıştı ve a = {a}");
        }

        public ConstructorMethods(int a, int b) : this(a)
        {
            Console.WriteLine($"3 . Constructrator methodu Çalıştı ve a = {a} ve b = {b}");
        }

        // her classın deafult constructoru vardır
        // eğer bir constructor tanımlanmazsa default constructor çalışır




    }
}
