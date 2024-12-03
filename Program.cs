




using OOP_EXERCISES;
using static OOP_EXERCISES.Records;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Merhaba BURASI MAIN!");


        /* 
        //ClassMembers classMembers = new ClassMembers(); // Nesne Oluşturuldu
        //ClassMembers classMembers2 = new ClassMembers(); // Nesne Oluşturuldu
        //classMembers.a = 5;
        //classMembers2.a = 10;
        //Console.WriteLine(classMembers.a);
        //Console.WriteLine(classMembers2.a);
        //int a = 15;
        //Console.WriteLine(a); // Hata verir. eğer a değişkenine değer atanmadıysa.
        */

        /* 
        ClassMembers fullProperty = new ClassMembers(); // Nesne Oluşturuldu
        fullProperty.Yas = 25;
        fullProperty.Kilo = "75";
        Console.WriteLine(fullProperty.Yas);
        Console.WriteLine(fullProperty.Kilo);
        */

        /* 
        // iç içe oluşturulan sınıfların örneklerinin oluşturulması
        ClassMembers2.nestedClassforClassMembers2 nestedClassforClassMembers2 = new ClassMembers2.nestedClassforClassMembers2();
        */

        /*
        ThisKeyword tk1 = new ThisKeyword();
        ThisKeyword tk2 = new ThisKeyword();

        tk1.x(2);
        tk2.x(4);
        */


        #region ObjectConcept
        // DEĞER TÜRLÜ DEĞİLSE REFERANS TÜRLÜ DEĞİŞKENDİR
        ObjectConcept objectConcept =   new ObjectConcept();
     ObjectConcept objectConcept2 = new();
     // Bu şekilde de nesne oluşturulabilir. ama bu nesne kullanılamaz. Çünkü referansı yok. garbage collector tarafından silinir.
     new ObjectConcept();
       // object initializer kullanımı böyledir ve bu şekilde nesne oluşturulur. a ya direkt değer atayabiliriz.
     ObjectConcept objectConcept3 = new ObjectConcept()
        {
            a = 5
        };
        #endregion


        #region ShallowCopy
        // aynı değeri birden fazla referansçı ile işaretlernir
        // burada 3 tane referans var ve hepsi aynı değeri işaret ediyor.
        ShallowAndDeepCopy shallowAndDeepCopy1 = new ShallowAndDeepCopy();
        ShallowAndDeepCopy shallowAndDeepCopy2 = shallowAndDeepCopy1;
        ShallowAndDeepCopy shallowAndDeepCopy3 = shallowAndDeepCopy2;

        ShallowAndDeepCopy shallowAndDeepCopy4 = new ShallowAndDeepCopy();
        #endregion

        #region DeepCopy
        //değer türlü değişkenlerde default olarak deep copy yapılır.
        // referans türlü değişkenlerde ise shallow copy yapılır.
        int a = 5;
        // a'nın değerini kopylayıp b'ye atar.
        int b = a;

        ShallowAndDeepCopy  m1 = new ShallowAndDeepCopy();
        ShallowAndDeepCopy m2 = m1; // Shallow Copy
        ShallowAndDeepCopy m3 = m1.Clone(); // Deep Copy 
        #endregion



        #region Encapsulation

        //Encapsulation encapsulation = new Encapsulation();
        //encapsulation.Bset(5);
        //Console.WriteLine(encapsulation.Bget());
        //encapsulation.C = 10;
        //Console.WriteLine(encapsulation.C);

        #endregion

        #region Records
        Records records = new Records();
        //records.Name = "can"; // readonly olduğu için hata verir.
        // records.Surname = "can"; // init-only olduğu için hata verir.
        Records record2 = new Records
        {
            Surname = "kelebekcan"
        };
        // record2.Surname = "kelebekcan"; // init-only olduğu için hata verir.
        //Console.WriteLine(record2.Surname);


        MyRecord myRecord1 = new MyRecord()
        {
            MyProperty = 5
        };
        MyRecord myRecord2 = new MyRecord()
        {
            MyProperty = 5
        };

        MyClass myClass1 = new MyClass()
        {
            MyProperty = 5
        };
        MyClass myClass2 = new MyClass()
        {
            MyProperty = 5
        };
        // recordlar default olarak değerlerine göre karşılaştırılır. true dönüş yapar
        // Console.WriteLine(myRecord1.Equals(myRecord2));
        // classlar default olarak referanslarına göre karşılaştırılır. false dönüş yapar
        //Console.WriteLine(myClass1.Equals(myClass2));

        #endregion

        #region ConstructorMethods

        //new ConstructorMethods();
        //new ConstructorMethods(5);
        //new ConstructorMethods(5, 10);

        #endregion

        #region DestructorMethods
        //int destSayısı = 100;
        //while (destSayısı > 0)
        //{
        //    DesctructorMETHOD desctructorMETHOD = new DesctructorMETHOD(destSayısı);
        //    destSayısı--;
        //}        
        //GC.Collect(); // Garbage Collector'ı çalıştırır. Destructor çalışır.
        //Console.ReadLine();

        #endregion




    }



}



    
    