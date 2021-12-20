using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Implementations;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class RegistrationForm : Form, IRegistrationView
    {
        public event Func<Task> Register;

        public UserModel NewUser => new UserModel
        {
            Login = loginTextBox.Text,
            Password = passwordTextBox.Text,
            RoleId = userTypeComboBox.SelectedIndex == 0 ?
                Roles.Candidate :
                Roles.Employer
        };

        public CandidateModel NewCandidateInfo => new CandidateModel
        {
            Initials = initialsTextBox.Text,
            DateOfBirth = dateOfBirthPicker.Value
        };

        public EmployerModel NewEmployerInfo => new EmployerModel
        {
            Name = nameTextBox.Text
        };

        public string[] Agencies
        {
            set => userTypeComboBox.Items.AddRange(value);
        }

        public bool Mode { get; set; }

        public RegistrationForm()
        {
            InitializeComponent();

            signUpBtn.Click += async (source, args) =>
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    ShowMessage("Пароли не совпадают.");
                    return;
                }

                await Register?.Invoke();
            };

            cancelBtn.Click += (source, args) => Close();
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void userTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (userTypeComboBox.SelectedIndex)
            {
                case 0:
                    Mode = true;

                    ClientSize = new Size(385, 215);

                    nameLabel.Visible = false;
                    nameTextBox.Visible = false;

                    initialsLabel.Visible = true;
                    initialsTextBox.Visible = true;
                    dateOfBirthLabel.Visible = true;
                    dateOfBirthPicker.Visible = true;
                    break;
                case 1:
                    Mode = false;

                    ClientSize = new Size(385, 190);

                    initialsLabel.Visible = false;
                    initialsTextBox.Visible = false;
                    dateOfBirthLabel.Visible = false;
                    dateOfBirthPicker.Visible = false;

                    nameLabel.Visible = true;
                    nameTextBox.Visible = true;
                    break;
            }
        }
    }
}
