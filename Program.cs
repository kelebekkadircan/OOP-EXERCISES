




using MyNameSpace;
using MyNameSpace2;
using OOP_EXERCISES;
using System.ComponentModel;
using System.Runtime.InteropServices;
using static OOP_EXERCISES.ClassMembers2;
using static OOP_EXERCISES.IInterfaces;
using static OOP_EXERCISES.Records;




class  Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Merhaba BURASI MAIN!");

        #region classMembers


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
        #endregion

        #region ThisKeyword

        /*
        ThisKeyword tk1 = new ThisKeyword();
        ThisKeyword tk2 = new ThisKeyword();

        tk1.x(2);
        tk2.x(4);
        */
        #endregion

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

        //// RECORDS STRUCTS
        PositionalRecord2 recordStructs = new PositionalRecord2(5, "can");
        //recordStructs.a = 10; // readonly olduğu için hata verir.
        
        PositionalRecordStructs positionalRecordStructs = new PositionalRecordStructs(20 , "kelebek");
        positionalRecordStructs.a = 1;
        positionalRecordStructs.b = "kelebekcan";
        //// burada record struclara değer atayabiliyoruz çünkü readonly değil.



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

        #region DeconstructorMethod

        DeconstructorMethod deconstructorMethod = new DeconstructorMethod
        {
            Name = "Kadircan",
            Age = 20
        };

        var (x,y) = deconstructorMethod;
        // Console.WriteLine(x);
        //Console.WriteLine(y);

        #endregion

        #region StaticConst

        // new StaticConst();
        // new StaticConst();
        // ilk static çalışır ve ikinci çağırışımızda çalışmaz

        #endregion

        #region  singleton

        //var signleton1 =  Singleton.GetInstance;    
        //var signleton2 =  Singleton.GetInstance;    
        //var signleton3 =  Singleton.GetInstance;    
        //  signleton1.ConnectionString = "asasfafsasf";
        //  Console.WriteLine(signleton1.ConnectionString);
        //  Console.WriteLine(signleton2.ConnectionString);
        //  Console.WriteLine(signleton3.ConnectionString);
        // iki ve üçüncü için de aynı connectionstring değerini verecektir yani singleton yapısıdır.


        #endregion

        #region PositionalRecord

        //PositionalRecord positionalRecord = new PositionalRecord("can", "kelebekcan");
        //Console.WriteLine(positionalRecord.name);
        //Console.WriteLine(positionalRecord.surname);
        //var (name, surname) = positionalRecord;
        //Console.WriteLine(name);
        //Console.WriteLine(surname);

        // positinoal record yapısını classlar desteklemez
        //new PositionalRecord();

        #endregion

        #region Inheritance

        //Inheritence.BMW bmw = new Inheritence.BMW();
        //bmw.Brand = "BMW";
        //Inheritence.Tesla tesla = new Inheritence.Tesla();
        //tesla.BatteryLife = 100;

        //// NAME HIDING VE OBJECTE BAKIŞ 3. DERS
        //Inheritence.B deneme = new Inheritence.B();
        //deneme.X = 5;
        //Console.WriteLine(deneme.X);
        //Inheritence.D deneme2 = new Inheritence.D();
        //deneme2.Y();




        #endregion

        #region  virtual | override
        //VirtualStructures virtualStructures = new VirtualStructures();
        //VirtualStructures.BaseClass baseClass = new VirtualStructures.BaseClass();
        //VirtualStructures.DerivedClass derivedClass = new VirtualStructures.DerivedClass();
        // baseClass.Display();
        //derivedClass.Display();

        //VirtualStructures.Ucgen ucgen = new VirtualStructures.Ucgen(5, 10); // 25
        //VirtualStructures.Dikdortgen dikdortgen = new VirtualStructures.Dikdortgen(5, 10); // 50
        //Console.WriteLine(ucgen.AlanHesapla());
        //Console.WriteLine(dikdortgen.AlanHesapla());

        #endregion

        #region Polimorfizim
        //// Polimorfizm kullanarak farklı ödeme türleri tanımlıyoruz.
        //Polimorfizim.Payment creditCardPayment = new Polimorfizim.CreditCardPayment();
        //Polimorfizim.Payment cashPayment = new Polimorfizim.CashPayment();
        //Polimorfizim.Payment bankTransferPayment = new Polimorfizim.BankTransferPayment();

        //// Ödeme işleme sınıfı
        //var paymentProcessor = new Polimorfizim.PaymentProcessor();

        //// Kredi Kartı ödemesi işleniyor
        //paymentProcessor.Process(creditCardPayment, 100.00m); // Çıktı: Credit Card payment of $100.00 processed.

        //// Nakit ödemesi işleniyor
        //paymentProcessor.Process(cashPayment, 50.00m); // Çıktı: Cash payment of $50.00 received.

        //// Havale/EFT ödemesi işleniyor
        //paymentProcessor.Process(bankTransferPayment, 200.00m); // Çıktı: Bank transfer of $200.00 initiated.





        #endregion

        #region SpecialKeywords

        // new SpecialKeywords(10, "can"); // 3 , 2 , 1 olan şeklinde gidip 1 , 2 , 3. olarak çalıştıracak stack mantığı
        // new SpecialKeywordsDerivedClass();

        #endregion

        #region SealedKeyword

        // new SealedKeyword();
        // new CSEALED().X();
        #endregion

        #region PartialStruct
        // partial altında aynı isimden iki farklı class var ve içerisindeki metotlara ulaşabiliriz.
        // compiler tek bir yapı varmış gibi davranır
        //PartialStructers partialStructers = new PartialStructers();
        //partialStructers.X();
        //partialStructers.Y();
        //PartialRecords partialRecords = new PartialRecords()
        //{
        //    name = "can",
        //    surname = "kelebekcan",
        //    age = 20
        //};
        //Console.WriteLine(partialRecords.name); // can veriyor



        #endregion

        #region AbstractClass
        //KadirAbstractClass kadir = new KadirAbstractClass();
        //kadir.Y();


        #endregion

        #region Interface
        // referans türlü değişkenlerdir yani bir referanstırlar
       // IInterfaces ıfirst = new denemeınterface();
        // IMyInterface ısecond = new denemeınterface();

        #endregion

        #region Namespace yapısı
        // kod organizasyonunu sağlaamak için kullanılır
        // kodu organize ederiz derli toplu olur namespaceler altında toplarız.
        // namespace herhangi bir cs dosyası içinde tanımlanabilir
        MyNameSpaceClass myNameSpaceClass = new MyNameSpaceClass();
        MyNameSpaceClass2 myNameSpaceClass2 = new MyNameSpaceClass2();
        //// burada namespace sadece bir tane file-scoped namespace izin veriyor hatası alırız
        //namespace OOP_EXERCISES;
        //namespace MyNameSpace;

        // farklı dosyalarda tanımlanmış aynı namespaceler compiler tarafından bütün olarak değerlendirilir. !!aynı derecede olmalıdır!!
        // using ile namespace tanımlanır ve kullanılır. using MyNameSpace; gibi
        //eğer aynı isimde class vs varsa namespacelere alias atanabilir using my = MyNameSpace; gibi ve my.MyNameSpaceClass şeklinde kullanılır.
        // 



        #endregion

        #region Collections
        //  Collections collections = new Collections();


        #endregion

        #region AnonymousTypes
        // AnonymousTypes anonymousTypes = new AnonymousTypes();
        //var data = new
        //{
        //    Name = "Kadircan",
        //    Surname = "Kelebek"
        //};
        //Console.WriteLine(data.Name);
        //Console.WriteLine(data.GetType().Name);
        #endregion

        #region NesnelOperatorler
        //// null conditional operatörü ?.
        ClassMembers classMembers = null;
        if (DateTime.Now.Day == 30)
            classMembers = new();
        //if (classMembers is not null )
        //    classMembers.Yas = 25;
        // set yaparken hata verir çünkü null olabilir
       // classMembers?.Yas = 25; 
        // ?. kullanrak null değilse çalıştır deriz get yaparken kullanılır
        var memberyasi = classMembers?.Yas; // şeklinde bir değişkene veriyi atarken null conditional kullanılır özellikle nested classlar için verimlidir.
        //Console.WriteLine(classMembers?.Yas);   

        //// null coalescing operatörü ??=
        ClassMembers classMembers1 = null;
        // eğer bu nesne null ise new yapar ve nesneyi oluşturur ??= sayesinde 
        classMembers1 ??= new();

        //// null operatörü ve nullable
        // değer türlü değişkenlerin null değeri alabilmesini sağlarlar.
        int? number1 = null;
        Nullable<int> number2 = null;
        //// is operatörü
        // bir değerin hangi türden olduğunu kontrol eder
        if (classMembers1.Yas is 25)
            // Console.WriteLine("yas 25");



        #endregion

        #region Enumerations
        // belirli sayısal değerleri sabitleştirilmiş metinsel karşılıklarıyla temsil eden bir türdür.
        //0 => bekliyor 
        //1 =>  hazırlanıyor
        //2 =>  yolda
        //3 => iptal edildi vs vs
        OrderStatus.Suspend.Equals(2);

        OrderStatus statu = OrderStatus.Completed;
        //string statu = OrderStatus.Completed.ToString();
        //Console.WriteLine(statu);
        #endregion


        #region Struct
        MyStruct structs = new(); // initialize edilir bu sayede default değerler atanır methodlar ve propertyler çalışır. 
        structs.X = 5;
        structs.Y = 10;
        //Console.WriteLine(structs.MyMethod());
        // structta yapılır  classların this keywordu readonly iken  structların değildir haliyle kendilerini newleyebilirler.
        structs.NewStruct();
        //  Console.WriteLine(structs.MyMethod());
        // içerisinde static yapıları barındırabilir.



        #endregion


        #region StaticBuilds
        ////StaticBuilds staticBuilds = new();
        //StaticBuilds staticBuilds = new();
        //var statikalaninadi = StaticBuilds.StaticField; // erişim direkt class üstünden ondan nesne türetmeden yapılır.
        //var alaninadi = staticBuilds.NonStaticField;
        
        //// Static olduğu için Instance oluşturlamaz
        //// ctor yasaktır
        //StaticBuilds2.StaticMethod2();
        //StaticBuilds3.StaticMethod3();
     



        #endregion
    }

}




