using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_EXERCISES
{
    public class Collections
    {
        // birden fazla veri üzerinde işlem yapmak için kullanılır.
        // diziler gibidir fakat daha gelişmiş halidir. dizilerde sınırlardan arındırır.
        // koleksiyonlar oop ile birlikte gelen özellikleri daha iyi kullanarak dizideki sınırlılıkları ortadan kaldırır.

        // dizilerin boyutları sabittir. koleksiyonlar dinamik veri yapılarıdır.
        // generic , non-generic  ve specialized koleksiyonlar vardır.
        // generic koleksiyonlar List<T> buradaki t => type anlamına gelir. generic yapıdır.
        // hata riskini azaltır ve tek tipte çalıştığı için performansı arttırır.
        // non-generic koleksiyonlar object tipinde çalışır. object tipi her türü alabilir.
        // specialized koleksiyonlar ise belirli bir türde veri alır. örneğin string türünde veri alır.
        // List<T> yapısı en çok kullanılan yapıdır . dinamiktir . t parametresi  türünü belirtir.  
        // Add() , Remove() , Clear() , Contains() , IndexOf() , Insert() ,
        // Sort() , Reverse() , ToArray() , TrimExcess() , Capacity , Count , ToArray() gibi metotları vardır.
        // Dictionary<Tkey,Tvalue> yapısı key ve value değerlerini tutar. key değerleri unique olmalıdır.
        // Add() , Remove() , Clear() , ContainsKey() , ContainsValue() , TryGetValue() , Keys , Values gibi metotları vardır.
        // Queue<T> yapısı first in first out mantığı ile çalışır. Enqueue() , Dequeue() , Peek()
        // Stack<T> yapısı last in first out mantığı ile çalışır. Push() , Pop() , Peek()
        // SortedList<Tkey,Tvalue> yapısı key ve value değerlerini tutar. key değerleri unique olmalıdır. IComperer interface'ini kullanır.
        // Add() , Remove() , Clear() , ContainsKey() , ContainsValue() , IndexOfKey() , IndexOfValue() , Keys , Values gibi metotları vardır.
        // SortedDictionary<Tkey,Tvalue> yapısı key ve value değerlerini tutar. key değerleri unique olmalıdır.
        // keylerin sıralı bir şekilde tutulması fakat özel bir key sıralaması istenmediğinde kullanılır.
        // ObservableCollection<T> yapısı observablecollection sınıfından türetilir. collectionchanged eventi ile çalışır.



    }
}
