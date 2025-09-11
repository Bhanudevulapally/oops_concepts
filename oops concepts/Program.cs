/*
using System;
public class Student
{
    int id;
    string name;
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.id = 101;
        s1.name = "bhanu";
        Console.WriteLine(s1.id);
        Console.WriteLine(s1.name);
    }
}



using System;
public class Employee
{
    int id;
    string name;
    public static void Main(string[] args)
    {
       Employee emp=new Employee();
        emp.id = 12345;
        emp.name = "venu";
        Console.WriteLine(emp.name);
        Console.WriteLine(emp.id);
    }
}

Having Main() in another class


using System;
public class Student
{
    public int id;
    public string name;
}
public class Teststudent
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.id = 101;
        s1.name = "bhanu";
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.id);
       
    }
}

initailize and display through  the object and update


using System;
public class Student
{
    public int id;
    public string name;
    public void insert(int i, string n)
    {
        id = i;
        name = n;

    }
    public void update(int i, string n)
    {
        id = i;
        name = n;

    }
    public void display()
    {
        Console.WriteLine(id + "." + name);
    }
}
class Teststudent
{
    public static void Main(string[] args)
    {
        Student s1= new Student();
        Student s2= new Student();
        Student s3 = new Student();
        s1.insert(101,"bhanu");
        s2.insert(102, "venu");
        s3.insert(103, "nagi");
        s1.update(1001, "bhai");
        s1.display();
        s2.display();
        s3.display();        
    }
}
   
   

Store and Dispay the Employee information

using System;
public class Employee
{
    public int id;
    public string name;
    public float salary;
    public void insert(int i , string n,float s)
    {
        id=i; name=n; salary=s;
    }
    public void display()
    {
        Console.WriteLine(id+"."+name+"  earn per month is:"+salary);
    }

}
public class Testemployee
{
    public static void  Main(string[] args)
    {
        Employee e1=new Employee();
        Employee e2=new Employee();
        e1.insert(101, "bhanu", 35000f);
        e2.insert(102, "venu", 35000f);
        e1.display();
        e2.display();
    }
}



constructors

using System;
public class  employee
{
    public employee()
    {
        Console.WriteLine("default Constructor Invoked");

    }
    public static void Main(string[] args)
    {
        employee e1 = new employee();
        employee e2 = new employee();
    }
}
default constructor with another class

using System;
 public class employee
{
    public employee()
    {
        Console.WriteLine("default Constructor Invoked");
    }
}
class testemployee
{
    public static void Main(string[] args)
    {
        employee e1 = new employee();
        employee e2 = new employee();
    }
}
parameterized Constructor

using System;
public class employee
{
    public int id;
    public string name;
    public float salary;
    public employee(int i,string n ,float s)
    {
        id = i;
        name = n;
        salary = s;

    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
public class testemployee
{
    public static void Main(string[] args)
    {
        employee e1 = new employee(101, "bhanu", 25000f);
        employee e2 = new employee(102, "venu", 24000f);
        e1.display();
        e2.display();
    }
}

using System;
  class employee
{
    private employee()
    {
        Console.WriteLine("default Constructor Invoked");

    }
    public static void Main(string[] args)
    {
        employee e1 = new employee();
        employee e2 = new employee();
    }
}

using System;
public class employee
{
    public int id;
    public string name;
    public float salary;
    private employee(int i, string n, float s)
    {
        id = i;
        name = n;
        salary = s;

    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}
public class testemployee
{
    public static void Main(string[] args)
    {
        employee e1 = new employee(101, "bhanu", 25000f);
        employee e2 = new employee(102, "venu", 24000f);
        e1.display();
        e2.display();
    }
}


using System;
public class employee
{
    static void Main(string[] args)
    {
        privateconstructor pc1 = new privateconstructor();
        Console.ReadLine();
    }
}
public class privateconstructor
{
    private privateconstructor()
    {
        Console.WriteLine("privateconstructor invoked");
    }
} //error occurs due to in accessible
public class dept: privateconstructor
{
}


staticConstructor


using System;
public class staticConstructor
{
    static staticConstructor()
    {
        Console.WriteLine("static Constructor Invoked");
    }
    public static void print()
    {
        Console.WriteLine();
            {
            Console.WriteLine("static private method called");
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            staticConstructor.print();
            Console.ReadLine();
        }
    }
}

copyConstructor

using System;
 public class CopyConstructor
{
    public string name;
    public CopyConstructor(string name)
    {
        this.name = name;
    }
    public CopyConstructor(CopyConstructor copy)
    {
        name=copy.name;
    }

}
class Program
{
    static void Main(string[] args)
    {
        CopyConstructor db = new CopyConstructor("hello");
        CopyConstructor bhanu=new CopyConstructor(db);
        Console.WriteLine("name:"+bhanu.name);
        Console.ReadLine();
    }
}

using System;
using System.Net.Sockets;
public  class CopyConstructor
{
    public string name;
    public  string address;
    public int id;
    public CopyConstructor(string name, string address, int id)
    {
        this.name = name;
        this.address = address;
        this.id = id;
    }
    public CopyConstructor(CopyConstructor copy)
    {
        name=copy.name;
        address=copy.address;
        id=copy.id;
    }
}
class Program
{
    static void Main(string[] args)
    {
        CopyConstructor c1 = new CopyConstructor("bhanu","ameerpet",799);
        CopyConstructor c2 = new CopyConstructor(c1);
        Console.WriteLine(c2.name+" "+c2.address+" "+c2.id);
        Console.ReadLine();

    }
}


 DESTRUCTOR 


using System;
public class Destructor
{
    public Destructor()
    {
        Console.WriteLine("constructor is invoked");
    }
    ~Destructor()
    {
        Console.WriteLine("destructor is invoked");

    }
}
class Program
{
    static void Main(string[] args)
    {
        Destructor d1 = new Destructor();
        Destructor d2 = new Destructor();
        d1=null;
        d2=null;
    }
}


using System;
public class employee
{
    public employee()
    {
        Console.WriteLine("Constructor is invoked");
    }
    ~employee()
    {
        Console.WriteLine("Destructor is invoked");
    }
}
class test
{
    static void Main()
    {
        employee e1 = new employee();
        employee e2 = new employee();

    }
}


using System;
namespace DestructorExample
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~DestructorDemo()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo obj1 = new DestructorDemo();
            DestructorDemo obj2 = new DestructorDemo();

            //Making obj1 for Garbage Collection
            obj1 = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}


USING THIS KEYWORD

using System;
public class employee
{
    public int id;
    public string Name;
    public float salary;
    public employee(int id, string name, float salary)
    {
         this.id = id;
         this.Name = name;
         this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine(id+" "+Name+" "+salary);
    }
}
class testemployee
{
    static void Main(string[] args)
    {
        employee e1= new employee( 101,"bhanu",25000f);
        employee e2 = new employee(102, "praveen", 35000f);
        e1.display();
        e2.display();   
    }
}

using System;
public class employee
{
    private int id;
    private string Name;
    private float salary;
    public employee(int id, string name, float salary)
    {
        this.id = id;
        this.Name = name;
        this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine(id + " " + Name + " " + salary);
    }
}
class testemployee
{
    static void Main(string[] args)
    {
        employee e1 = new employee(101, "bhanu", 25000f);
        employee e2 = new employee(102, "praveen", 35000f);
        e1.display();
        e2.display();
    }
}



using System;
public class ages
{
    public int id;
    public string name;
    public int age;
    public ages(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    public void display()
    {
        Console.WriteLine(id+" "+name+" "+age);
    }
    public void copyFrom(ages other)
    {
        if (this != other)
        {
            this.name=other.name;
            this.age=other.age;
        }
    }  
}
class testages
{
    public static void Main (string[] args)
    {
        ages a1 = new ages(01, "praveen", 25);
        ages a2 = new ages(02, "bhanu", 22);
        a1.display();
        a2.display();

        a1.copyFrom(a2);
        a2.display();
    }
}

STATIC CONSTRUCTOR



using System;
public class Account
{
    public int accno;
    public string name;
    public static float rateofinterest = 8.8f;
    public Account(int accno, string name)
    {
        this.accno = accno;
        this.name = name;
    }
    public void display()
    {
    Console.WriteLine(accno+" "+name+" "+rateofinterest);

    }
}
public class testAccount
{
    public static void Main(string[] args)
    {
        Account a1 = new Account(101, "bhanu");
        Account a2 = new Account(102, "venu");
        a1.display();
        a2.display();
    }
}
CHANGING THE STATIC VARIABLES

using System;
public class Account
{
    public int accno;
    public string name;
    public static float rateofinterest = 8.8f;
    
    public Account(int accno, string name)
    {
        this.accno = accno;
        this.name = name;
    }
    public void display()
    {
        Console.WriteLine(accno + " " + name+" "+rateofinterest);
    }
}
public class testAccount
{
    public static void Main(string[] args)
    {
        Account.rateofinterest = 10.5f;
        Account a1 = new Account(1, "bhanu");
        Account a2 = new Account(2, "venu");
        a1.display();
        a2.display();
    }
}

using System;
public class Account
{
    public int accno;
    public string name;
    public static int count = 0;
    public Account(int accno, string name)
    {
        this.accno = accno;
        this.name = name;
        count++;
    }
    public void display()
    {
        Console.WriteLine(accno + ". " + name);
    }

}
public class TestAccount
{
   public static void Main(string[] args)
    {
        Account a1 = new Account(1, "bhanu");
        Account a2 = new Account(2, "bala");
        Account a3 = new Account(3, "venu");
        Account a4 = new Account(4, "nagi");
        Account a5 = new Account(5, "praveen");
        Console.WriteLine("total objects are:" + Account.count);
        Console.WriteLine("the objects are:-");
        a1.display();
        a2.display(); a3.display(); a4.display(); a5.display();
    }
}


STATIC CLASS USED 

using System;
using System.Reflection.Metadata.Ecma335;
public static class MyMath
{
    public static float PI = 3.14f;
    public static int cube(int n)
    {
        return n * n * n;
    }
}
class TestMyMath
{
    public static void Main(string[] args)
    {
        Console.WriteLine("value of PI is:-"+ MyMath.PI);
        Console.WriteLine("cube of 5 is:-"+MyMath.cube(5));
    }
}

    
NOT USING RETURN TYPE IN STATIC CLASS


using System;
public static class mymath
{
    public static void cube(int n)
    {
        Console.WriteLine(n * n * n);
    }
}
class testmymath
{
    public static void Main(string[] args)
    {
     mymath.cube(3);   
    }
}

using System;
public class Account
{
    public string Name;
    public int id;
    public static float rateofinterest;
    public Account(string name, int id)
    {
        this.Name = name;
        this.id = id;
    }
    static Account()
    {
        rateofinterest=3.14f;
    }
    public void display()
    {
        Console.WriteLine(id + " " + Name + " " + rateofinterest);
    }
}
class Testaccount
{
    public static void Main(string[] args)
    {
        Account a1 = new Account("satwika", 101);
        Account a2 = new Account("nagi", 102);
        a1.display();
        a2.display();
    }
}



using System;
public class employee //class
{
    public employee() //constructor
    {

    }
    private int experience; //field
    public int exper //property for get set
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }
    public void calculatesalary() //method
    {
        int salary = experience * 30000;
        Console.WriteLine("salary:{0}",salary);
    }
    static void Main(string[] args) //main method
    {
        employee obj= new employee();
        obj.experience = 5;
        obj.calculatesalary();
        Console.ReadLine();
    }
}


INHERITANCE

using System;
public class employee
{
    public int experience {  get; set; }
    public void calculatesalary()
    {
        int salary = experience * 10000;
        Console.WriteLine("salary:{0}",salary);
    }

}
public class paremanenetemployee : employee
{

    //code
    
}

class testEmployee
{
    static void Main(string[] args)
    {
        //paremanenetemployee pemployee = new paremanenetemployee();
        //pemployee.experience = 5;
        //pemployee.calculatesalary();
        employee emp = new employee();
        emp.experience = 5;
        emp.calculatesalary();
    }
}
 SINGLE LEVEL INHERITANCE USING FIELDS

using System;
public class employee

{
    public float salary = 40000;

}
public class programmer:employee

{
    public float bonus = 10000;
}
class testinheritance
{
    public static void Main(string[] args)
    {
        programmer p1 = new programmer();
        Console.WriteLine("salary" + p1.salary);
        Console.WriteLine("bonus"+p1.bonus);
       
     
    }
}
MULTIPLE  INHERITANCE
USING INTERFACE IT CAN ONLY DECLARE NOT IMPLEMENT THE STATEMENT

using System;
public class baseclass
{
    public void animal()
    {
        Console.WriteLine("animal");

    }
}
    interface I2
    {
        public void fly();
    }

    public class derived:baseclass,I2
    {
        public void eagle()
        {
            Console.WriteLine("eagle");
        }
        public void fly()
        {
            Console.WriteLine("fly");
        }

    }

class inhertance
{
    public static void Main(string[] args)
    {
        derived d1=new derived();
       d1.animal();
        d1.fly();
        d1.eagle();
        baseclass d2=new baseclass();
        d2.animal();
        d2.
    }
}

using System;
public class employee
{
    public float salary = 40000;
}
public class programmer:employee
{
    public float bonus = 10000;
}
class test
{
    public static void Main(string[] args)
    {
        programmer p1 = new programmer();
        Console.WriteLine("salary"+p1.salary);
        Console.WriteLine("bonus"+p1.bonus);
    }
}

SINGLE LEVEL USING METHODS

using System;
public class danger
{
    public void eat()
    {
        Console.WriteLine("she can eat the brain");
    }
    public void drink()
    {
        Console.WriteLine("she can drink blood also");
    }
}
    public class satwika:danger
    {
        public void beat()
        {
            Console.WriteLine("she always beats me");

        }
    }

public class inheritance
{
    public static void Main(string[] args)
    {
        satwika s1 = new satwika();
        Console.WriteLine("satwika");
        s1.eat();
        s1.drink();
        s1.beat();
    }
}


MULTI LEVEL INHERITANCE

using System;
public class Animal
{
    public void eat()
    {
        Console.WriteLine("eating");

    }
}
public class dog: Animal
{
    public void bark()
    {
        Console.WriteLine("barking");

    }
}
public class  babydog :dog
{
    public void weep()
    {
        Console.WriteLine("weeping");

    }
}
class testmultilevel
{
    public static void Main(string[] args)
    {
        babydog bdg=new babydog();
        bdg.eat();
        bdg.bark();
        bdg.weep();
        dog dg = new dog();
        dg.eat();
        dg.bark();
        Animal a1 = new Animal();
        a1.eat();
    }
}


HIERARCHICAL INHERITANCE

using System;
public class baseclass
{
    public void Animal()
    {
        Console.WriteLine("Animal");

    }
}
public class dervidedclass:baseclass
{
    public void dog()
    {
        Console.WriteLine("dog");

    }
}
public class dervidedclass2 : baseclass
{
    public void cat()
    {
        Console.WriteLine("cat");

    }
}
public class dervidedclass3 : baseclass
{
    public void horse()
    {
        Console.WriteLine("horse");

    }
}
class testheirachal
{
    public static void Main(string[] args)
    {
        dervidedclass3 dc3= new dervidedclass3();
        dervidedclass2 dc2= new dervidedclass2();
        dervidedclass dc1 = new dervidedclass();
        baseclass bc = new baseclass();
        dc3.horse();
        dc3.Animal();
        dc2.cat();
        dc2.Animal();
        dc1.dog();
        dc1.Animal();
        bc.Animal();    


    }
}

HYBRID INHERITANCE

using System;
public class Animal
{
    public void eat()
    {
        Console.WriteLine("eating");

    }
    interface ISwim
    {
        void Swim();
    }
    interface IFly
    {
        public void Fly();
    }
    interface ISleep
    {
        public void Sleep();
    }

    class Dog : Animal, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("dod is swimming");
        }
        public void bark()
        {
            Console.WriteLine("dog is barking");
        }
        //single inheritance (animal-->bird)+interface implementation
    }
        class Bird:Animal,IFly
        {
            public void Fly()
            {
                Console.WriteLine("bird is flying");
            }
            public void chip()
            {
                Console.WriteLine("bird is chipping");

            }
        }
        class Duck:Animal,IFly,ISwim
        {
            public void Swim()
            {
                Console.WriteLine("duck is swimming");

            }
            public void Fly()
            {
                Console.WriteLine("duck is flying");
            }
            public void Quack()
            {
                Console.WriteLine("Duck is barking like quack quack!!!");
            }
        }

    public static void Main(string[] args)
    {
        Duck dc=new Duck();
        dc.Fly();
        dc.Quack();
        dc.Swim();
        dc.eat();
        Bird bir=new Bird();
        bir.Fly();
        bir.chip();
        bir.eat();
        Dog dg=new Dog();
        dg.eat();
        dg.bark();
        dg.Swim();


    }
}

MULTIPLE INHERITANCE

using System;
public class Animal
{
    public void fly()
    {
        Console.WriteLine("flying");
    }
    interface ISwim
    {
        public void Swim();
    }
    public class Parrot : Animal, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("parrot is swimming");
        }
        public void Eat()
        {
            Console.WriteLine("eating");
        }

    }

    class Testinherotance
    {
        public static void Main(string[] args)
        {
            Parrot pr = new Parrot();
            pr.fly();
            pr.Eat();
            pr.Swim();
            Animal a1 = new Animal();
            a1.fly();
        }
    }
}




ACCESS SPECIFIERS
PUBLIC SPECIFIER

using System;
namespace AccessSpecifiers
{
    class PublicTest
    {
        public string name = "santosh kumar";
        public void Msg(string msg)
        {
            Console.WriteLine("hello"+msg);
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            PublicTest publictest = new PublicTest();
            //accessing the public variable
            Console.WriteLine( "hello"+publictest.name);// hello santosh kumar
            //acccesing the public function
            publictest.Msg(" petu decostar");//hello petu decostar

        }
    }
}
PROCTEDED SPECIFIER

using System;
namespace AccessSpecifier
{
    class ProctedTest
    {
        protected string name = "shahshikanth";
        protected void Msg(string msg)
        {
            Console.WriteLine("hello"+msg);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ProctedTest test = new ProctedTest();
            Console.WriteLine("hello"+test.name);
            test.Msg("swami Ayyer")
        }
    }
}
//OUTPUT: COMPLIE ERROR
// 'test.name' is inaccesible due to its protection level


using System;
namespace AccessSpecifier
{
    class ProtectedTest
    {
        protected string name = "shashikanth";
        protected void Msg(string msg)
        {
            Console.WriteLine( "hello "+msg);
        }
    }
    class Program:ProtectedTest
    {
        public static void Main(string[] args)
        {
            Program protectedtest=new Program();
            //accessing the protected variable
            Console.WriteLine("hello "+protectedtest.name);
            //accessing the protected function
            protectedtest.Msg("swami ayyer"); 
        }
    }
}


using System;

 public class HelloWorld
{
    protected string name = "bhanu prasad";

    protected void msg(string messege)
    {
        Console.WriteLine("hello " + messege);
    }

    // Public method to safely access protected members
    public void Show()
    {
        Console.WriteLine("hello " + name);
        msg("good morning");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HelloWorld h = new HelloWorld();
        h.Show();   
    }
}

using System;
namespace AccessSpecifiers
{
    class InternalTest
    {
        internal string name = "bhanu";
        internal void Msg(string msg)
        {
            Console.WriteLine("hello"+msg);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            InternalTest test = new InternalTest();
            Console.WriteLine("hello "+test.name);//hello bhanu
            test.Msg(" good morning");// hello good morning
        }
    }
}


PROTCTED INTERNAL ACCESS SPECIFIER

using System;
namespace AccessSpecifiers
{
    class ProtectedinternalTest
    {
        protected internal string name = "Bhanu";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("hello "+msg);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ProtectedinternalTest test = new ProtectedinternalTest();
            Console.WriteLine("hello "+test.name); //hello Bhanu
            test.Msg("Good Morning");//hello Good Morning
        }
    }
}
PRIVATE ACCESS SPECIFIRS 

using System;
namespace AccessSpcifiers
{
    class Privatetest
    {
        private string name = "bhanu";
        private void Msg(string msg)
        {
            Console.WriteLine("hello"+msg);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Privatetest test = new Privatetest();
            Console.WriteLine("hello" + test.name);//compile error
            //tets.name is inaccessible due to its protection level
            test.msg("hello");
        }
    }
}
// to get the accessible we should write the code within the class

using System;
namespace AccessSpcifiers
{
    class Privatetest
    {
        private string name = "bhanu";
        private void Msg(string msg)
        {
            Console.WriteLine("hello" + msg);
        }
        public static void Main(string[] args)
        {
            Privatetest test = new Privatetest();
            Console.WriteLine("hello " + test.name);//hello bhanu
            test.Msg(" good Morning");// hello good Morning
        }
    }
}



using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            SBI sbi = new SBI();
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.CheckBalanace();
            sbi.BankTransfer();
            sbi.MiniStatement();

            Console.WriteLine("\nTransaction doing AXIX Bank");
            AXIX AXIX = new AXIX();
            AXIX.ValidateCard();
            AXIX.WithdrawMoney();
            AXIX.CheckBalanace();
            AXIX.BankTransfer();
            AXIX.MiniStatement();

            Console.Read();
        }
    }

    public class SBI
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }

    public class AXIX
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}

using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            IBank sbi = BankFactory.GetBankObject("SBI");
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.CheckBalanace();
            sbi.BankTransfer();
            sbi.MiniStatement();

            Console.WriteLine("\nTransaction doing AXIX Bank");
            IBank AXIX = BankFactory.GetBankObject("AXIX");
            AXIX.ValidateCard();
            AXIX.WithdrawMoney();
            AXIX.CheckBalanace();
            AXIX.BankTransfer();
            AXIX.MiniStatement();

            Console.Read();
        }
    }

    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }

    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBI();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIX();
            }
            return BankObject;
        }
    }

    public class SBI : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }

    public class AXIX : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}



using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            IBank sbi = BankFactory.GetBankObject("SBI");
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.CheckBalanace();
            sbi.BankTransfer();
            sbi.MiniStatement();

            Console.WriteLine("\nTransaction doing AXIX Bank");
            IBank AXIX = BankFactory.GetBankObject("AXIX");
            AXIX.ValidateCard();
            AXIX.WithdrawMoney();
            AXIX.CheckBalanace();
            AXIX.BankTransfer();
            AXIX.MiniStatement();

            Console.Read();
        }
    }

    public abstract class IBank
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalanace();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }

    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBI();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIX();
            }
            return BankObject;
        }
    }

    public class SBI : IBank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public override void CheckBalanace()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public override void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }

    public class AXIX : IBank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public override void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }

        public override void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}

INTERFACE

using System;
public interface Drawable
{
    void draw();

}
public class Rectangle:Drawable
{
    public void draw()
    {
        Console.WriteLine("draw the rectangle");
    }
}
public class Circle : Drawable
{
    public void draw()
    {
        Console.WriteLine("draw the circle");
    }
}
public class Testinterface
{
    public static void Main(string[] args)
    {
        Drawable d;
        d = new Circle();
        d.draw();
        d =new Rectangle();
        d.draw();
       
    }
}


using System;
public interface Drawble
{
    public abstract void draw();
}
public class Rectangle : Drawble
{
    public void draw();// Complile time error
    {
    ---------------------?
}



NAMESPACES

using System;
namespace Consoleapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello NameSpace");
        }
    }
}


using System;
namespace first
{
    public class Hello
    {
        public void sayhello()
        { System.Console.WriteLine("first Namespace"); }
    }
    namespace second
    {
        public class Hello
        {
            public void sayhello
                ()
            { System.Console.WriteLine("second namespace"); }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                first.Hello FH = new first.Hello();
                second.Hello SH = new second.Hello();
                FH.sayhello();
                SH.sayhello();
            }
        }
    }
}
*/
using System;
using first;
using second;
namespace first
{
    public class Hello
    {

        public void sayhi()
        {
            Console.WriteLine("hi namespace");
        }
    }
}
    namespace second
    {
        public class Welcome
        {
            public void welcome()
            {
                Console.WriteLine("Hello welcome");
            }
        }
    }
    class Testprogram
    {
        public static void Main()
        {
            Hello HF = new Hello();
            Welcome WH = new Welcome();
            HF.sayhi();
            WH.welcome();
        }
    }

