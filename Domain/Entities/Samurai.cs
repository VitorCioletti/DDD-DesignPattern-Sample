namespace DomainDrivenDevelopment.Domain.Entities
{
    using DomainDrivenDevelopment.Domain.DependencyInjection;
    using DomainDrivenDevelopment.Domain.Infrastructure;

    //Domain cannot see Infrastructure layer, even so, it can call a method from it. 'Inversion of Control'
    public class Samurai
    {
        public void Attack()
        {
            /*There are no class coupling here. 'Solve' receives an Interface as parameter and do its job in order to return an object of the instance
            and it calls the method Attack*/
            Dependencies.Solver.Solve<IFight>().Attack();
            //Just as an example, it is possible to do this because the dependecy injection instantiates a Fight object.
            IFight fight = Dependencies.Solver.Solve<IFight>();
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
