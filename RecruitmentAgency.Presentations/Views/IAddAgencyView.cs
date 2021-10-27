using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
	public interface IAddAgencyView : IView
	{
		Func<Task> AddAgency { get; set; }
		AgencyModel NewAgency { get; }
	}
}
