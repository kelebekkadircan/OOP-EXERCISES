using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class ThisKeyword
    {
        int a;
        public void x(int a)
        {
            Console.WriteLine("ThisKeywordMethod");
            //this.x();
            //Console.WriteLine( this + " in anlamı budur");
            Console.WriteLine(this.a); //fielddaki a yı temsil eder
             Console.WriteLine(a);// parametredeki a yı temsil eder



        }
    }
}
