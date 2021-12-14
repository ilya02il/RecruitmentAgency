using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using RecruitmentAgency.UI.Common;
using System.Drawing;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Implementations
{
    public class EditAgencyForm : EditForm, IEditView<AgencyModel>
    {
		private Label _nameLabel;
		private TextBox _nameTextBox;
		public EditAgencyForm() : base()
		{
			_nameLabel = new Label
			{
				AutoSize = true,
				Location = new Point(12, 15),
				Name = "nameLabel",
				Size = new Size(62, 15),
				TabIndex = 0,
				Text = "Название:"
			};

			_nameTextBox = new TextBox
			{
				Location = new Point(80, 12),
				Name = "nameTextBox",
				Size = new Size(292, 23),
				TabIndex = 1
			};

			Name = "EditAgencyForm";
			Text = "Редактирование агенства";

			Controls.Add(_nameLabel);
			Controls.Add(_nameTextBox);
		}

		public AgencyModel OriginalModel
        {
			set => _nameTextBox.Text = value.Name;
        }

		public AgencyModel EditedModel => new AgencyModel()
		{
			Name = _nameTextBox.Text
		};
    }
}
