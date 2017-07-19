namespace DomainDrivenDevelopment.Domain.DependencyInjection
{
    public interface ISolve
    {
        T Solve<T>();
    }
}
