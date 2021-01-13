//Andreas Ranzmaier 02.11.2020
using System;

namespace _18Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Aufruf();
        }

        static void Aufruf()
        {
            Child c1 = new Child();
            c1.PrintParent();

            //todo: int 1 ist unnötig 
            Child c2 = new Child(1, "name");
            c2.PrintParent();
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

        // überladener
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

    class Child : Parent
    {
        //DECLARATIONS
        //KONSTRUKTOREN
        public Child()
        {
            Console.WriteLine("Child");
        }

        // ruft den überladenen Konstruktor der Parent Klasse auf 
        public Child(int id, string name) : base(name)
        {
            Console.WriteLine("Child Parameter");
        }
        //GET SET
        //METHODEN
    }
