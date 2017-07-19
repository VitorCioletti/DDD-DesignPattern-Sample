namespace DomainDrivenDevelopment.Domain.DependencyInjection
{
    using System;
    public class SolverNotConfiguratedException : Exception
    {
        public SolverNotConfiguratedException() :
            base(string.Format("There are no instances of \"{0}\" at the Depedency.",typeof(ISolve).Name)) { }
    }
}
