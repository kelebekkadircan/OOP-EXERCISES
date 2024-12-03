using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class DesctructorMETHOD
    {
        // sadece class yapılandırasında kullanılabilir . 
        // 1 tane destructor olabilir
        int no;
        public DesctructorMETHOD(int no)
        {
            this.no = no;
            Console.WriteLine($"{no}. nesne yaratıldı");
        }
        ~DesctructorMETHOD()
        {
            Console.WriteLine($"{no}. nesne imha edildi");
        }

        public void X ()
        {
            Console.WriteLine("x calıstı");
        }

    }
}
