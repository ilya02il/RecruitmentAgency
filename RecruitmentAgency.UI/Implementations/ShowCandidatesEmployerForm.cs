using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using RecruitmentAgency.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class ShowCandidatesEmployerForm : Form, IShowCandidatesEmployerView
    {
        public event Action<CandidateModel> AcceptCandidate;
        public event Action<CandidateModel> DeclineCandidate;
        public event Action PrintCandidatesList;

        public IEnumerable<CandidateModel> Candidates
        {
            set => candidatesDataGridView.LoadData(value, "Initials", "DateOfBirth");
        }

        public ShowCandidatesEmployerForm()
        {
            InitializeComponent();

            acceptBtn.Click += (source, args) => AcceptCandidate?.Invoke(GetSelectedCandidate());
            declineBtn.Click += (source, args) => DeclineCandidate?.Invoke(GetSelectedCandidate());
            printBtn.Click += (source, args) => PrintCandidatesList?.Invoke();
        }

        private CandidateModel GetSelectedCandidate()
        {
            var selectedRow = candidatesDataGridView.GetSelectedRow();
            return new CandidateModel
            {
                Initials = selectedRow.Cells[nameof(initialsColumn)].Value.ToString(),
                DateOfBirth = Convert.ToDateTime(selectedRow.Cells[nameof(dateOfBirthColumn)].Value)
            };
        }

        public new void Show() => ShowDialog();
    }
}
