using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Common
{
    public partial class EditForm : Form
	{
		public Func<Task> Edit { get; set; }

		public EditForm()
		{
			InitializeComponent();

			cancelBtn.Click += (sender, args) => Close();

			ControlAdded += ResizeForm;
		}

		public new void Show()
		{
			ShowDialog();
		}

		private async void submitBtn_Click(object sender, EventArgs e)
		{
			await Edit?.Invoke();
			Close();
		}

		private void ResizeForm(object sender, ControlEventArgs e)
		{
			var height = e.Control.Top + e.Control.Height + 45;
			ClientSize = new Size(ClientSize.Width, height);
		}
	}
}
