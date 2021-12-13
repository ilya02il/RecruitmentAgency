using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using System.Drawing;
using System.Windows.Forms;
using RecruitmentAgency.UI.Common;

namespace RecruitmentAgency.UI
{
    public class AddAgencyForm : AddForm, IAddView<AgencyModel>
    {
		private Label _nameLabel;
		private TextBox _nameTextBox;
        public AddAgencyForm() : base()
        {
			_nameLabel = new Label
			{
				AutoSize = true,
				Location = new Point(12, 15),
				Name = "nameLabel",
				Size = new Size(62, 15),
				TabIndex = 0,
				Text = "Название:",
				Anchor = AnchorStyles.Top | AnchorStyles.Left
			};

			_nameTextBox = new TextBox
			{
				Location = new Point(80, 12),
				Name = "nameTextBox",
				Size= new Size(292, 23),
				TabIndex = 1,
				Anchor = AnchorStyles.Top | (AnchorStyles.Left | AnchorStyles.Right)
			};

			Name = "AddAgencyForm";
			Text = "Добавление агенства";

			Controls.Add(_nameLabel);
			Controls.Add(_nameTextBox);
		}

        public AgencyModel NewModel
		{
			get
			{
				return new AgencyModel()
				{
					Name = _nameTextBox.Text
				};
			}
		}
    }
}
