using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class Polimorfizim
    {
        // yazılımda polimorfizim olabilmesi için kalıtım şarttır
        // aralarında kalıtımsal ilişki bulunan sınıflar arasında polimorfizim olabilir.

        // Poliormizim: Bir nesnenin farklı türlerde kullanılabilmesidir.
        // referansı büyük olan verir base olan ata olan
        BaseClass policlass = new DerivedClass();
        // DerivedClass derivedClass = new BaseClass(); // hata verir

        public class BaseClass
        {

        }
 
        public class DerivedClass : BaseClass
        {

        }

        // GPT EXAMPLE
        public abstract class Payment
        {
            // Ödeme işlemini başlatan metot (temel sınıf)
            public abstract void ProcessPayment(decimal amount);
        }

        // Kredi Kartı ödemesi sınıfı (Türetilmiş Sınıf)
        public class CreditCardPayment : Payment
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Credit Card payment of {amount:C} processed.");
                // Burada kredi kartı işlem mantığı yazılabilir.
            }
        }

        // Nakit ödemesi sınıfı (Türetilmiş Sınıf)
        public class CashPayment : Payment
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Cash payment of {amount:C} received.");
                // Nakit ödeme işlemi burada modellenir.
            }
        }

        // Havale/EFT ödemesi sınıfı (Türetilmiş Sınıf)
        public class BankTransferPayment : Payment
        {
            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Bank transfer of {amount:C} initiated.");
                // Banka transferi mantığı burada yazılır.
            }
        }

        // Polimorfizmin kullanıldığı sınıf
        public class PaymentProcessor
        {
            // Tüm ödeme türlerini tek bir metotla işleyen polimorfik yapı
            public void Process(Payment paymentMethod, decimal amount)
            {
                // Farklı ödeme türlerini bu metotla işleyebiliyoruz.
                paymentMethod.ProcessPayment(amount);

            }
        }

      // STATIC POLIMORPIZM VE POLİFORMİZM TÜRLERİ CAST,İS VE AS KULLANIMI



    }
}
