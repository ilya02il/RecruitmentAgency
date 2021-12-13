namespace RecruitmentAgency.Presentations.Common
{
	public class BasePresenter<TView> : IPresenter
		where TView : IView
	{
		protected TView View { get; }
		protected IApplicationController Controller { get; }

		protected BasePresenter(IApplicationController controller, TView view)
		{
			Controller = controller;
			View = view;
		}

		public virtual void Run()
		{
			View.Show();
		}
	}
	public abstract class BasePresenter<TView, TArg> : IPresenter<TArg>
		where TView : IView
	{
		protected TView View { get; }
		protected IApplicationController Controller { get; }

		protected BasePresenter(IApplicationController controller, TView view)
		{
			Controller = controller;
			View = view;
		}

		public abstract void Run(params TArg[] arguments);
		public abstract void Run(TArg argument);
	}
}
