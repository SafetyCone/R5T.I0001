using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0147;
using R5T.T0132;


namespace R5T.I0001
{
	[FunctionalityMarker]
	public partial interface IServiceActionOperator : IFunctionalityMarker,
		T0147.IServiceActionOperator
	{
		public IServiceAction<IServiceCollection> AddServiceCollection(IServiceCollection services)
        {
			var serviceAction = this.New<IServiceCollection>(services => services.AddServiceCollection());
			return serviceAction;
        }
	}
}