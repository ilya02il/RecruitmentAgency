namespace RecruitmentAgency.Presentations.Common
{
	public interface IApplicationController
	{
		void Run<TPresenter, TArgument>(params TArgument[] arguments) where TPresenter : class, IPresenter<TArgument>;
	}
}