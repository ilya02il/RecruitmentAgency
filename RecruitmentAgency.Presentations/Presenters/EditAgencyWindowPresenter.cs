﻿using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class EditAgencyWindowPresenter : BasePresenter<IEditView<AgencyModel>, AgencyModel>
    {
        private readonly IAgencyService _agencyService;

        public EditAgencyWindowPresenter(IApplicationController controller, IEditView<AgencyModel> view, IAgencyService agencyService)
            : base(controller, view)
        {
            _agencyService = agencyService;

            View.Edit += EditAgencyAsync;
        }

        public override void Run(params AgencyModel[] arguments)
        {
            View.OriginalModel = arguments[0];
            View.Show();
        }

        public override void Run(AgencyModel argument)
        {
            View.OriginalModel = argument;
            View.Show();
        }

        private async Task EditAgencyAsync()
        {
            await _agencyService.UpdateAgencyInfo(View.EditedModel);
        }
    }
}
