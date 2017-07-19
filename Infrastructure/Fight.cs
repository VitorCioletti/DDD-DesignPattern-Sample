namespace DomainDrivenDevelopment.Infrastructure
{
    using System;
    using DomainDrivenDevelopment.Domain.Infrastructure;
    public class Fight : IFight
    {
        public void Attack()
        {
            Console.WriteLine("Attacking...");
        }
        public void Defend()
        {
            Console.WriteLine("Defending...");
        }
        public void PrepareStance()
        {
            Console.WriteLine("Preparing Stance...");
        }
    }
}
