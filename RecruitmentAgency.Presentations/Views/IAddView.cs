using RecruitmentAgency.Presentations.Common;
using System;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
	public interface IAddView<TModel> : IView
		where TModel : class
	{
		Func<Task> Add { get; set; }
		TModel NewModel { get; }
	}
	public interface IAddView<TModel, TArg> : IView
		where TModel : class
	{	
        TArg[] Arguments { set; }
        Func<Task> Add { get; set; }
		TModel NewModel { get; }
	}
}
