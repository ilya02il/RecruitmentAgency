namespace RecruitmentAgency.Presentations.Common
{
	public interface IApplicationController
	{
		void Run<TPresenter>()
		   where TPresenter : class, IPresenter;
		void Run<TPresenter, TArgument>(TArgument argument)
			where TPresenter : class, IPresenter<TArgument>;
		void Run<TPresenter, TArgument>(params TArgument[] arguments)
			where TPresenter : class, IPresenter<TArgument>;
	}
}