﻿using System;
using System.Linq.Expressions;

namespace _08_Inheritance
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }
        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }
        public void BaseMethod()
        {
            Console.WriteLine($"{this.Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }
        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }
        public void DerivedMethod()
        {
            Console.WriteLine($"{this.Name}.DerivedMethod()");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
