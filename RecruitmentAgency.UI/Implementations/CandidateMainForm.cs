using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using RecruitmentAgency.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class CandidateMainForm : Form, ICandidateMainView
    {
        public event Action<VacancyModel> RespondToVacancy;

        public IEnumerable<VacancyModel> Vacancies
        {
            set => vacanciesDataGridView.LoadData(value, "EmployerName", "Position", "Salary");
        }

        private readonly ApplicationContext _context;

        public CandidateMainForm(ApplicationContext context)
        {
            _context = context;

            InitializeComponent();

            respondBtn.Click += (source, args) =>
            {
                var selectedRow = vacanciesDataGridView.GetSelectedRow();

                var selectedVacancy = new VacancyModel
                {
                    EmployerName = selectedRow.Cells[nameof(vacancyEmployerColumn)].Value.ToString(),
                    Position = selectedRow.Cells[nameof(vacancyPositionColumn)].Value.ToString(),
                    Salary = Convert.ToInt32(selectedRow.Cells[nameof(vacancySalaryColumn)].Value)
                };

                RespondToVacancy?.Invoke(selectedVacancy);
            };
        }

        public new void Show()
        {
            _context.MainForm = this;

            if (Application.OpenForms.Count > 0)
            {
                base.Show();
            }
            else
            {
                Application.Run(_context);
            }
        }
    }
}
