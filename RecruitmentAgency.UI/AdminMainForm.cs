using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
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
				case "agenciesTabPage":
					AddAgency?.Invoke();
					break;
				case "vacanciesTabPage":
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
	}
}
