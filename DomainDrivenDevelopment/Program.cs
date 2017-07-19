namespace DomainDrivenDevelopment.Apresentation
{
    using DomainDrivenDevelopment.DependencyInjection;
    using DomainDrivenDevelopment.Domain.DependencyInjection;
    using DomainDrivenDevelopment.Domain.Entities;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Dependencies.Solver = new Solver();
            Samurai samurai = new Samurai();
            samurai.PrepareStance();
            samurai.Defend();
            samurai.Attack();
            Console.ReadKey();
        }
    }
}
