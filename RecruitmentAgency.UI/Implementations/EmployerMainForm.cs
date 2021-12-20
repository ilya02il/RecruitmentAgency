using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using RecruitmentAgency.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class EmployerMainForm : Form, IEmployerMainView
    {
        public Action AddVacancy { get; set; }
        public Action<VacancyModel> EditVacancy { get; set; }
        public Action<VacancyModel> ShowCandidates { get; set; }
        public Func<VacancyModel, Task> DeleteVacancy { get; set; }

        public IEnumerable<VacancyModel> Vacancies
        {
            set => vacanciesDataGridView.LoadData(value, "Position", "Salary");
        }

        public EmployerModel CurrentEmployer { get; set; }

        private readonly ApplicationContext _context;

        public EmployerMainForm(ApplicationContext context)
        {
            _context = context;

            InitializeComponent();

            addNewRecordBtn.Click += (source, args) => AddVacancy?.Invoke();
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

        private void editRecordBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = vacanciesDataGridView.GetSelectedRow();

            var selectedVacancy = new VacancyModel()
            {
                Position = selectedRow.Cells[nameof(vacancyPositionColumn)].Value.ToString(),
                Salary = Convert.ToInt32(selectedRow.Cells[nameof(vacancySalaryColumn)].Value),
                EmployerName = CurrentEmployer.Name
            };

            EditVacancy?.Invoke(selectedVacancy);
        }

        private async void removeRecordBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = vacanciesDataGridView.GetSelectedRow();

            var selectedVacancy = new VacancyModel()
            {
                Position = selectedRow.Cells[nameof(vacancyPositionColumn)].Value.ToString(),
                Salary = Convert.ToInt32(selectedRow.Cells[nameof(vacancySalaryColumn)].Value),
                EmployerName = CurrentEmployer.Name
            };

            await DeleteVacancy?.Invoke(selectedVacancy);
        }

        private void showCandidatesBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = vacanciesDataGridView.GetSelectedRow();

            var selectedVacancy = new VacancyModel()
            {
                Position = selectedRow.Cells[nameof(vacancyPositionColumn)].Value.ToString(),
                Salary = Convert.ToInt32(selectedRow.Cells[nameof(vacancySalaryColumn)].Value),
                EmployerName = CurrentEmployer.Name
            };

            ShowCandidates?.Invoke(selectedVacancy);
        }
    }
}
