namespace DomainDrivenDevelopment.Domain.Entities
{
    using DomainDrivenDevelopment.Domain.DependencyInjection;
    using DomainDrivenDevelopment.Domain.Infrastructure;

    public class Samurai
    {
        public string name;

        public void Attack()
        {
            Dependencies.Solver.Solve<IFight>().Attack();
        }
        public void PrepareStance()
        {
            Dependencies.Solver.Solve<IFight>().Defend();
        }
        public void Defend()
        {
            Dependencies.Solver.Solve<IFight>().PrepareStance();
        }
    }
}
