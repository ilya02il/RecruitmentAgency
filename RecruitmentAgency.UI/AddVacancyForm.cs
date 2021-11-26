using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI
{
    public partial class AddVacancyForm : Form, IAddVacancyView
    {
        public Func<Task> AddVacancy { get; set; }

        public IEnumerable<string> AgenciesNames
        {
            set => agencyNameComboBox.Items.AddRange(value.ToArray());
        }

        public VacancyModel NewVacancy
        {
            get
            {
                return new VacancyModel()
                {
                    Position = positionTextBox.Text,
                    Salary = Convert.ToInt32(salaryTextBox.Text),
                    AgencyName = agencyNameComboBox.Text
                };
            }
        }

        public AddVacancyForm()
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
            await AddVacancy?.Invoke();
            Close();
        }
    }
}
