using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
   public class SpecialKeywordBaseClass
    {
        public int deneme { get; set; }
        public int deneme2 { get; set; }

        public int a { get; set; }



    }
    public class SpecialKeywords : SpecialKeywordBaseClass
    {
        // this keyword
        // bir  sınıfın herhangi bir metodu içerisinde o sınıfın herhangi bir elemanına erişmek için kullanılır.
        // this keywordu sınıfın içerisindeki birden fazla overload ctor içerisinde atlamamızı sağlar
        public int a { get; set; } 
        public SpecialKeywords()
        {
            Console.WriteLine($" içi boş olan Constructor çalıştı a : {this.a}");
            this.x = "readonly Constructor";
           
        }public SpecialKeywords(int a) : this()
        {
            Console.WriteLine(" tek değişkenli olan Constructor çalıştı");
        }
        public SpecialKeywords(int a , string b) : this(a)
        {
            Console.WriteLine(" iki değişkenli olan Constructor çalıştı");
        }



        // base keyword
        // base classın instranceını temsil eden keyworddur.
        // kalıtım almıyorsa object sınıfını kullanır.
        // base keywordu consructor seçimi yapmamımızı da sağlar
         



        // readonly keyword
        // ya set ettğin an değer verirsin ya da constructor içerisinde değer verirsin.
        readonly object x = "readonly";
        // const ile farkı const tanımlandığı an verilmeli
        // readonly istersen const üzerinden verilir ayrıca const static bir yapılandırmadır.

        // const yapılanmalar readonly ile karışıtırılsa da aralarındaki fark const tanımlandığı
        // yerde değeri verilmeliri ve ctor içerisinde değer ataması gerçekleştirilemez lakin readonly
        // kullanımında ister tanımlarken ister ctor içerisinde değer atanabilir
        // temel farklardan biri budur. const static yapılanmadır



    }

    public class  SpecialKeywordsDerivedClass : SpecialKeywords
    {
        public SpecialKeywordsDerivedClass() : base(10,"abc")
        {
            base.a = 10;
            Console.WriteLine("SpecialKeywordsDerivedClass Constructor çalıştı");
            Console.WriteLine(a);
        }
        
    }



}
