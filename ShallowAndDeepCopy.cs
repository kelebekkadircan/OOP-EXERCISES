using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class ShallowAndDeepCopy
    {
        // Shallow Copy
        // var olan bir nesnenin referansının kopyalanmasıdır eldeki
        // değeri çoğaltmaz aynı değer birden fazla referansçı ile işaretlernir
        // birden fazla referansla işaretlenmesi gerekiyor !! bunu unutmamak lazım


        // Deep Copy
            public ShallowAndDeepCopy Clone()
            {
            return (ShallowAndDeepCopy)this.MemberwiseClone();


            }





    }
}
