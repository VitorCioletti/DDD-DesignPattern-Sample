namespace DomainDrivenDevelopment.Domain.Infrastructure
{
    public interface IFight
    {
        //This interface is declares at the domain, altought, it is implemented at infrastructure layer.
        void Attack();
        void PrepareStance();
        void Defend();
    }
}
