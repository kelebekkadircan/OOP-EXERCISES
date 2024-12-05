using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class VirtualStructures
    {
        // sanal yapıları niye kullanıyoruz ? nelere dikkat etmeliyiz ? sanal yapılar nelerdir ?
        // türeyen  alt sınıflarda da tekrar tanımlanabilen yapılar sanal yapılar olarak adlandırılır.
        // eğer sanal bir yapı varsa bunun parentta mı childda mı çağıralacağı run time da belirlenir.

        // late binding nedir ? 

        public class BaseClass
        {
            public virtual void Display()
            {
                Console.WriteLine("Base Class virtual yapıldı");
            }
        }

        public class DerivedClass : BaseClass
        {
            public override void Display()
            {
                Console.WriteLine("Derived Class override edildi");
            }
        }

        // override edilecekse kesinlikle virtual olarak işaretlenemsi gerekiyor.

        public class Sekil
        {
            protected int _boy;
            protected int _en;

            public Sekil(int boy, int en)
            {
                _boy = boy;
                _en = en;
            }

           virtual public int AlanHesapla()
            {
                return 0;
            }


        }

        public class Dikdortgen : Sekil
        {
            public Dikdortgen(int boy, int en) : base(boy , en)
            {

            }

            public override int AlanHesapla()
            {
                return _boy * _en;
            }

        }
        public class Ucgen : Sekil
        {
            public Ucgen(int boy , int en) : base(boy , en)
            {

            }

            public override int AlanHesapla()
            {
                return _boy * _en / 2;
            }


        }





    }
}
