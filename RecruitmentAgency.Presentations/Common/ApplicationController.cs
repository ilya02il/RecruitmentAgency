using Autofac;

namespace RecruitmentAgency.Presentations.Common
{
	public class ApplicationController : IApplicationController
	{
		private readonly IComponentContext _context;

		public ApplicationController(IComponentContext context)
		{
			_context = context;
		}

		public void Run<TPresenter, TArgument>(params TArgument[] arguments)
			where TPresenter : class, IPresenter<TArgument>
		{
			var presenter = _context.Resolve<TPresenter>();
			presenter.Run(arguments);
		}
	}
}
