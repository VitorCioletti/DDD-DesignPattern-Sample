namespace DomainDrivenDevelopment.DependencyInjection
{
    using DomainDrivenDevelopment.Domain.DependencyInjection;
    using DomainDrivenDevelopment.Domain.Infrastructure;
    using DomainDrivenDevelopment.Infrastructure;
    using Microsoft.Practices.Unity;

    public class Solver : ISolve
    {
        private UnityContainer _container = new UnityContainer();
        public Solver()
        {
            _container.RegisterType<IFight,Fight>();
        }
        public T Solve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
