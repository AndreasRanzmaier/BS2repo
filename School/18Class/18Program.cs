using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace _18Class
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }

    class Parent
    {
        //DECLARATIONS
        protected int id;
        private string name;

        //KONSTRUKTOREN
        public Parent()
        {
            id = 0;
            name = "Parent";
            Console.WriteLine("Parent");
        }

        protected Parent(string name)
        {
            this.name = name;
            Console.WriteLine("Parent Parameter");
        }

        //GET SET

        //METHODEN
        public void PrintParent ()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
        }

    }

    class Child : Parent()
    {
        //DECLARATIONS
        //KONSTRUKTOREN
        //GET SET
        //METHODEN

    }
}
