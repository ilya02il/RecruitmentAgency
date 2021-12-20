using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;

namespace RecruitmentAgency.Presentations.Views
{
    public interface IShowCandidatesEmployerView : IView
    {
        IEnumerable<CandidateModel> Candidates { set; }

        event Action<CandidateModel> AcceptCandidate;
        event Action<CandidateModel> DeclineCandidate;
        event Action PrintCandidatesList;

        void Show();
    }
}