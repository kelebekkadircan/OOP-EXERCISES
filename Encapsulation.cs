using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class Encapsulation
    {
        // herkesin erişimine açmadan verilerin kafasına göre değiştirilmesini engellemek için kullanılır.
        // metot ile encapsulation yapılır.

        // property ile encapsulation yapılır.

        // field içerisindeki değere erişilir
        public int a;
        // erişilemez
        private int b;

        private int c;

        // metot ile erişim
        public int Bget()
        {
            return this.b;
        }
        public void Bset(int value)
        {
            this.b = value;
        }

        // property ile erişim
        public int C
        {
            get
            {
                return this.c;
            }
            set
            {
                this.c = value;
            }

        }


    }

    
}
