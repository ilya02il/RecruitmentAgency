using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
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
		}

		public Action AddAgency { get; set; }
		public Action<AgencyModel> EditAgency { get; set; }
		public Func<AgencyModel, Task> DeleteAgency { get; set; }
		public Action AddVacancy { get; set; }
		public Action<VacancyModel> EditVacancy { get; set; }
		public Func<VacancyModel, Task> DeleteVacancy { get; set; }

        public IEnumerable<AgencyModel> Agencies
		{
			set => dataGridView1.LoadData(value, "Name");
		}

		public IEnumerable<VacancyModel> Vacancies
		{
			set => dataGridView2.LoadData(value, "Position", "Salary", "AgencyName");
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

		private void addNewRecordBtn_Click(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedTab.Name)
			{
				case nameof(agenciesTabPage):
					AddAgency?.Invoke();
					break;
				case nameof(vacanciesTabPage):
					AddVacancy?.Invoke();
					break;
			}
		}

		private void editRecordBtn_Click(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedTab.Name)
			{
				case nameof(agenciesTabPage):
					var selectedRow = dataGridView1.GetSelectedRow();

					var selectedAgency = new AgencyModel()
					{
						Name = selectedRow.Cells[nameof(agencyNameColumn)].Value.ToString()
					};

					EditAgency?.Invoke(selectedAgency);
					break;

				case nameof(vacanciesTabPage):
					selectedRow = dataGridView2.GetSelectedRow();

					var selectedVacancy = new VacancyModel()
					{
						Position = selectedRow.Cells[nameof(vacancyPositionColumn)].Value.ToString(),
						Salary = Convert.ToInt32(selectedRow.Cells[nameof(vacancySalaryColumn)].Value),
						AgencyName = selectedRow.Cells[nameof(vacancySalaryColumn)].Value.ToString()
					};

					EditVacancy?.Invoke(selectedVacancy);
					break;
			}
		}

		private async void removeRecordBtn_Click(object sender, EventArgs e)
        {
			switch (tabControl1.SelectedTab.Name)
			{
				case nameof(agenciesTabPage):
					var selectedRow = dataGridView1.GetSelectedRow();

					var selectedAgency = new AgencyModel()
					{
						Name = selectedRow.Cells[nameof(agencyNameColumn)].Value.ToString()
					};

					await DeleteAgency?.Invoke(selectedAgency);
					break;
				case nameof(vacanciesTabPage):
					selectedRow = dataGridView2.GetSelectedRow();

					var selectedVacancy = new VacancyModel()
					{
						Position = selectedRow.Cells[nameof(vacancyPositionColumn)].Value.ToString(),
						Salary = Convert.ToInt32(selectedRow.Cells[nameof(vacancySalaryColumn)].Value),
						AgencyName = selectedRow.Cells[nameof(vacancySalaryColumn)].Value.ToString()
					};

					await DeleteVacancy?.Invoke(selectedVacancy);
					break;
			}
		}
    }

    internal static class DataGridViewExtension
	{
		public static void LoadData<TRecord>(this DataGridView dataGridView, IEnumerable<TRecord> records, params string[] properties)
			where TRecord : class
		{
			dataGridView.Rows.Clear();

			foreach (var record in records)
			{
				List<object> values = new();

				foreach (var property in record.GetType().GetProperties())
				{
					if (!properties.Any(p => p == property.Name))
						continue;

					var value = property.GetValue(record);

					values.Add(value);
				}

				dataGridView.Rows.Add(values.ToArray());
			}
		}

		public static DataGridViewRow GetSelectedRow(this DataGridView dataGridView)
        {
			var selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;

			return dataGridView.Rows[selectedRowIndex];
        }
	}
}
