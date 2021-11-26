using Autofac;

namespace RecruitmentAgency.Presentations.Common
{
	public class ApplicationController : IApplicationController
	{
		private readonly ILifetimeScope _scope;

		public ApplicationController(ILifetimeScope scope)
		{
			_scope = scope;
		}

		public void Run<TPresenter, TArgument>(params TArgument[] arguments)
			where TPresenter : class, IPresenter<TArgument>
		{
			using var nestedScope = _scope.BeginLifetimeScope();

			var presenter = nestedScope.Resolve<TPresenter>();
			presenter.Run(arguments);
		}
	}
}
