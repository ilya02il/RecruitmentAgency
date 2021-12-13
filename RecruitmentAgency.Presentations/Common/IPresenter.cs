namespace RecruitmentAgency.Presentations.Common
{
	public interface IPresenter
	{
		void Run();
	}
	public interface IPresenter<in TArg>
	{
		void Run(TArg arguments);
		void Run(params TArg[] argument);
	}
}
