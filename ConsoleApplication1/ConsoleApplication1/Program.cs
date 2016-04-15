using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BaseClass
    {
        public void Print()
        {
            Console.WriteLine("Base Class Method");
        }

        public virtual void PrintO()
        {
            Console.WriteLine("Base Class Method :Print O");
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("Derived Class Method");
        }
        public override void PrintO()
        {
            Console.WriteLine("Derived Class Method :Print O");
        }
    }

    public class A { }
    public class B { }
    //public class C : A, B  //We cannot add multiple base classes for derived class.
    //{


    //}

    interface I1
    {
        void InterfaceMethod();
    }// public is by default access modifier for interface.
    interface I2
    {
        void InterfaceMethod();
    }
    class InterClass : I1, I2 // We can have multiple Interfaces for derived class.
    {
       void I1.InterfaceMethod()
        {        
            Console.WriteLine("Interface Method : I1");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("Interface Method : I2");
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("Interface Method");
        }
    }
    


    //-------------------------------------------------------
    public abstract class MainClass
    {
        public string firstname;
        public string lastname;
        public abstract void GetName();
    }
    public class SubClass:MainClass
    {
        public override void GetName() // Since Method is declared in abtract class , Derived class is forced to implement the method using overide keyword.
        {
            Console.WriteLine(firstname + " " + lastname);
        }
    }
         



    
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new DerivedClass();
            bc.Print();//Run Base Class method and hide derived class method since new keyword is added.
            bc.PrintO();//Run Derived class method since base class is using virtual and derived class is using overide.

            //MainClass mc = new MainClass(); // We cannot create instance of abstract class.
            SubClass sc = new SubClass();
            sc.firstname = "Ajinkya";
            sc.lastname = "Desai";
            sc.GetName();

            InterClass ic = new InterClass();
            ic.InterfaceMethod();

            I1 i1 = new InterClass();
            i1.InterfaceMethod();

            I2 i2 = new InterClass();
            i2.InterfaceMethod();

            //(I1)ic.InterfaceMethod();
            //(I2)ic.InterfaceMethod();
            ((I1)ic).InterfaceMethod();
            ((I2)ic).InterfaceMethod();

            Console.ReadLine();

        }
    }
}
