using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public record PositionalRecord(string name , string surname)
    {
        // kendi içerisinde bir structor ve değişken oluşturur bunu arka planda yapar
        // positinoal record yapısını classlar desteklemez
        // c# 9.0 ile gelmiştir
        // constructor ve deconstruct yapısını hızlıca oluşturmaya yarıyan bir semantiktir


        //// Aslında bunu arka planda oluşturur
        ///// oluştururken değer atanır ama daha sonra değiştirilemez
        //public string name { get; init; }
        //public string surname { get; init; }

        //public void Deconstruct(out string name, out string surname)
        //{
        //    name = this.name;
        //    surname = this.surname;
        //}

        public PositionalRecord() : this("kadir" ,"kelebek")
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"{surname}");

        }

    }
}
