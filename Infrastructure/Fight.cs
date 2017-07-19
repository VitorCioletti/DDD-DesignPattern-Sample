namespace DomainDrivenDevelopment.Infrastructure
{
    using System;
    using DomainDrivenDevelopment.Domain.Infrastructure;
    //Here happens all the implementation of interfaces created at Domain level.
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
