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
                EmployerName = selectedRow.Cells[nameof(vacancySalaryColumn)].Value.ToString()
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
                EmployerName = selectedRow.Cells[nameof(vacancySalaryColumn)].Value.ToString()
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
                EmployerName = selectedRow.Cells[nameof(vacancySalaryColumn)].Value.ToString()
            };

            ShowCandidates?.Invoke(selectedVacancy);
        }
    }
}
