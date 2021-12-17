using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Implementations;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class RegistrationForm : Form, IRegistrationView
    {
        public event Func<Task> Register;

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
        }

        public new void Show()
        {
            ShowDialog();
        }

        public UserModel NewUser => new UserModel
        {
            Login = loginTextBox.Text,
            Password = passwordTextBox.Text,
            RoleId = Roles.Candidate
        };

        public string[] Agencies
        {
            set => agencyComboBox.Items.AddRange(value);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
