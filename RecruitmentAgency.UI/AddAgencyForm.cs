using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI
{
	public partial class AddAgencyForm : Form, IAddAgencyView
	{
		public Func<Task> AddAgency { get; set; }

		public AgencyModel NewAgency
		{
			get
			{
				return new AgencyModel()
				{
					Name = agencyNameTextBox.Text
				};
			}
		}

		public AddAgencyForm()
		{
			InitializeComponent();

			cancelBtn.Click += (sender, args) => Close();
		}

		public new void Show()
		{
			ShowDialog();
		}

		private async void submitBtn_Click(object sender, EventArgs e)
		{
			await AddAgency?.Invoke();
			Close();
		}
	}
}
