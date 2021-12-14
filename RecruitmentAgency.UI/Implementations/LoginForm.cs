using RecruitmentAgency.Presentations.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class LoginForm : Form, ILoginView
    {
        public event Func<Task> Login;
        public event Action Register;

        public string Username
        {
            get => loginTextBox.Text;
            set => loginTextBox.Text = value;
        }

        public string Password
        {
            get => passwordTextBox.Text;
            set => passwordTextBox.Text = value;
        }

        private readonly ApplicationContext _context;

        public LoginForm(ApplicationContext context)
        {
            _context = context;

            InitializeComponent();
        }

        public new void Show()
        {
            _context.MainForm = this;

            Application.Run(_context);
        }

        private async void signInButton_Click(object sender, EventArgs e)
        {
            await Login?.Invoke();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
