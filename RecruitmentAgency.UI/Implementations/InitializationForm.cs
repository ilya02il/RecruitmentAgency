using RecruitmentAgency.Presentations.Views;
using System;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public partial class InitializationForm : Form, IInitializationView
    {
        public Action LoadUsers { get; set; }
        public InitializationForm()
        {
            InitializeComponent();

            Shown += (sender, args) => LoadUsers?.Invoke();
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void ChangeStatus(string status)
        {
            statusLabel.Text = status;
        }
    }
}
