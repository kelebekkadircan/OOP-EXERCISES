using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public partial class PartialStructers
    {
        // büyük yapıları bölüp üzerinde çalışmak için yapabiliriz.
        // ekiplerin aynı sınıfın farklı kısımlarını aynı anda geliştirmesini de sağlar.
         // partial classlar aynı namespace içerisinde olmalıdır.
         // partial keywordü ile işaretlenmelidir.
         // nested yapılarda kullanılabilir
         // yapıları aynı olmak zorunda ve namespace aynı olmalı örneğin aynı namespacedeki class ya da interface vs vs


        public void X () 
        {
            Console.WriteLine("X");
        }

    }
    public partial class PartialStructers
    {
        public void Y()
        {
            Console.WriteLine("Y");
        }


    }


    public partial record PartialRecords
            {
        public string name { get; set; }
        public string surname { get; set; }
    } 
    public partial record PartialRecords
       {
        public int age { get; set; }
        
    }



    // template code yapısı için yani bir şablon oluşturmak için partial kullanılabilir.
    // partial method kullanımı
    // void olmak zorundadır ve geri dönüş tipi olamaz.
    // partial methodlar gövdeleri tanımmlanırsa public olarak işaretlenemebilir
    public partial interface IPartialInterface
    {
        public partial void X();
        void Y();



    }
    public partial interface IPartialInterface
    {
        // gövdesi olduğu için public alabildi sadece imzası varsa public alamaz
        public partial void X()
        {
            Console.WriteLine("x partialınterface");
        }
    }




}
