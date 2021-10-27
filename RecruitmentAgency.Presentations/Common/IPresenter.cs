namespace RecruitmentAgency.Presentations.Common
{
	public interface IPresenter<in TArg>
	{
		void Run(params TArg[] arguments);
	}
}
