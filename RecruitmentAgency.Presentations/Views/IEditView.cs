using RecruitmentAgency.Presentations.Common;
using System;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
    public interface IEditView<TModel> : IView
		where TModel : class
	{
		Func<Task> Edit { get; set; }
		TModel OriginalModel { set; }
		TModel EditedModel { get; }
    }
	public interface IEditView<TModel, TArg> : IView
		where TModel : class
	{
		TArg[] Arguments { set; }
		Func<Task> Edit { get; set; }
		TModel OriginalModel { set; }
		TModel EditedModel { get; }
	}
}
