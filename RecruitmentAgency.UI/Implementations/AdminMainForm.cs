using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using RecruitmentAgency.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI
{
    public partial class AdminMainForm : Form, IAdminMainView
	{
		private readonly ApplicationContext _context;
		public AdminMainForm(ApplicationContext context)
		{
			_context = context;

			InitializeComponent();

			addNewRecordBtn.Click += (source, args) => AddVacancy?.Invoke();
		}

		public Action AddVacancy { get; set; }
		public Action<VacancyModel> EditVacancy { get; set; }
		public Action<VacancyModel> ShowCandidates { get; set; }
		public Func<VacancyModel, Task> DeleteVacancy { get; set; }
		public Func<EmployerModel, Task> DeleteEmployer { get; set; }


		public IEnumerable<VacancyModel> Vacancies
		{
			set => vacanciesDataGridView.LoadData(value, "Position", "Salary", "AgencyName");
		}

		public IEnumerable<EmployerModel> Employers
		{
			set => vacanciesDataGridView.LoadData(value, "Name");
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
			DataGridViewRow selectedRow;

			switch (tabControl1.SelectedTab.Name)
			{
                case nameof(vacanciesTabPage):
                    selectedRow = vacanciesDataGridView.GetSelectedRow();

                    var selectedVacancy = new VacancyModel()
                    {
                        Position = selectedRow.Cells[nameof(vacancyPositionColumn)].Value.ToString(),
                        Salary = Convert.ToInt32(selectedRow.Cells[nameof(vacancySalaryColumn)].Value),
                        EmployerName = selectedRow.Cells[nameof(vacancySalaryColumn)].Value.ToString()
                    };

                    await DeleteVacancy?.Invoke(selectedVacancy);
                    break;
				case nameof(employersTabPage):
					selectedRow = employersDataGridView.GetSelectedRow();

					var selectedEmployer = new EmployerModel
					{
						Name = selectedRow.Cells[nameof(organizationNameColumn)].Value.ToString()
					};

					await DeleteEmployer?.Invoke(selectedEmployer);
					break;
            }
		}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
			switch (tabControl1.SelectedTab.Name)
            {
				case nameof(vacanciesTabPage):
					addNewRecordBtn.Enabled = true;
					editRecordBtn.Enabled = true;
					showCandidatesBtn.Enabled = true;
					break;
				case nameof(employersTabPage):
					addNewRecordBtn.Enabled = false;
					editRecordBtn.Enabled = false;
					showCandidatesBtn.Enabled = false;
					break;
            }
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
