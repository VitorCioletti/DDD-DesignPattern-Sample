namespace DomainDrivenDevelopment.Domain.Infrastructure
{
    public interface IFight
    {
        //This interface is declared at the domain, however, it is implemented at infrastructure layer.
        void Attack();
        void PrepareStance();
        void Defend();
    }
}
