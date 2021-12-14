using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class AgencyMainWindowPresenter : BasePresenter<IAgencyMainView>
    {
        public AgencyMainWindowPresenter(IApplicationController controller, IAgencyMainView view) : base(controller, view)
        {
        }
    }
}
