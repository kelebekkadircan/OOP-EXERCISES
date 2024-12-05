using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public sealed class SealedKeyword
    {
        // sealed keywordü ile işaretlenirse kalıtım alınamaz.
        // bu sınıfı inherit edemeyiz.
        public SealedKeyword()
        {

            Console.WriteLine("SealedKeyword Constructor");

        }

        // sadece sınıflarda ve override edilmiş metotlarda kullanılır
        // override edilmiş virtual memberı daha sonra tekrar override edilmesin diye sealed edebiliriz

    }
    //public class SealedKeywordDerived : SealedKeyword
    //{


    //}

   public class ASEALED
    {
        public virtual void X()
        {
            Console.WriteLine(" MERHABA BEN  A SINIFIYIM ");

        }
    }
    public class BSEALED : ASEALED
    {
       sealed public override void X()
        {
            Console.WriteLine(" MERHABA BEN  B SINIFIYIM ");

        }
    }
    public class CSEALED : BSEALED
    {
        //public override void X()
        //{
        //    Console.WriteLine(" MERHABA BEN  C SINIFIYIM ");

        //}
    }
}
