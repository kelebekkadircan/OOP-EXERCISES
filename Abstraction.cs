using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public abstract class Abstraction
    {
        // asbtraction bir mantık ve davranıştır.
        // abstarct classların günün sonunda stackte referans noktası edinilebilir ve heapte bellek alanı oluşturulabilir.
        // soyut olduğu için new operatörü ile nesne üretilemez  => new Abstarcyion() hata verecektir
        // eğer abstract classtan türeyen bir sınıf newlenirse abstract classın constructorı çalışır.
        // asbtract classta nesneyi biz üretmeyiz ama onun bir nesnesi olur kalıtımsal hiyerarşi yoluyla ama interface de bu mümkün değil nesne üretemeyiz
        // abstract class keywordünü kullanmamız lazım => abstract class Deneme gibi

        // eğer abstract değilse gövdesi olması lazım

        int a;
        void X()
        {
            Console.WriteLine("X");
        }

        // abstract ise zorunlu olarak implemente ediliir ve gövde zorunlu değil
        public abstract void Y();
        public abstract int Z { get; set; }


    }

    public class DenemeDerivedAbstraction : Abstraction
    {
        // override etmek zorundayız
        public override int Z { get; set; }
        // abstract classın abstract metodu implemente edilmek zorunda
        // virtual override edilmek zorunda değil ama abstract override edilmek zorunda eğer inherit edildiyse (implement ) 
        // override edilen yapıların public olması zorunludur
        public override void Y()
        {
            Console.WriteLine("Y");
        }

        // eğer bazı metot ve yapıların override etmesini kesin olarak istiyorsak abstract classa başvururuz ve onları abstract keywordü ile işaretleriz sonra da implemente edip override ederiz böylece  o methodu override etmesini zorunlu kılmış oluruz
    }


    // bu duruma inheritence diyebiliriz.
        public abstract class  InheritenceAbstractClass : Abstraction
        {


        }

    // inherit içerisinde bir metot olmamasına rağmen inherit ettiğim abstraction classına gidip içindekileri implemente eder.
    public class KadirAbstractClass : InheritenceAbstractClass
    {
        public override int Z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Y()
        {
            Console.WriteLine("Y");
        }
    }

}
