using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class StaticConst
    {
        // bir sınıf tetiklenirken oluşan ilk fonkysion constructor fonksiyonudur.
        // önce static constructor tetiklenir
        // ctor her nesne üretildiğinde üretilir fakat staticctor sadece bir kere üretilir ve ilk seferde olur.
        

        public StaticConst()
        {
            // bu sınıftan nesne üretilirse ilk tetiklenecek olan metottur.
            Console.WriteLine("Constructor Oluşturuldu");
        }

        // erişim belirleyicisi dediğimiz public or private yoktur
        // geri dönüş tipi yoktur bildiirilmez.
        // overloading yapılmaz 1 tanedir.
        // parametre almaz.
        static StaticConst()
        {
            // bu sınıftan ilk nesne üretildiğinde ilk tetiklenecek olan metottur.
            // üretilen ilk nesenenin dışında bir daha da çalışmaz
            Console.WriteLine("Static Constructor Oluşturuldu");
            // static const oluşması için bir nesne üretilmesine gerek yoktur.
            // herhangi bir static yapılandırma tetiklenmesi de çalışmasını sağlar
            // öyle ya da böyle 1 kere tetiklenecek.

        }

    }

    class Singleton
    {

        private Singleton()
        {
            Console.WriteLine($"Singleton Oluşturuldu : {ConnectionString}");
            
        }

        public string ConnectionString { get; set; }

        static Singleton singleton;

        static public Singleton GetInstance
        {
            get
            {
                return singleton;
            }
        }

        static Singleton()
        {
            Console.WriteLine("Static Singleton Constructor Oluşturuldu");
            singleton = new Singleton();
        }


    }


}
