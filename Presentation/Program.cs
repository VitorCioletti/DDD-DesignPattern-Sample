namespace DomainDrivenDevelopment.Presentation
{
    using DomainDrivenDevelopment.DependencyInjection;
    using DomainDrivenDevelopment.Domain.DependencyInjection;
    using DomainDrivenDevelopment.Domain.Entities;
    using System;
    class Program
    {
        //I hope this helps you :)
        static void Main(string[] args)
        {
            /*This line is very important because it instantiates a Solver object to make the connection between
            the Domain and Dependency Injection layers.
             */
            Dependencies.Solver = new Solver();
            Samurai samurai = new Samurai();
            samurai.PrepareStance();
            samurai.Defend();
            samurai.Attack();
            Console.ReadKey();
        }
    }
}
