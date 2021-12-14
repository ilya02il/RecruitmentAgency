﻿using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Views;
using RecruitmentAgency.UI.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RecruitmentAgency.UI
{
    public class AddVacancyForm : AddForm, IAddView<VacancyModel, string>
    {
        private Label _positionLabel;
        private Label _salaryLabel;
        private Label _agencyNameLabel;
        private TextBox _positionTextBox;
        private TextBox _salaryTextBox;
        private ComboBox _agencyNameComboBox;
        public AddVacancyForm() : base()
        {
            _positionLabel = new Label
            {
                AutoSize = true,
                Location = new Point(12, 15),
                Name = "positionLabel",
                Size = new Size(72, 15),
                TabIndex = 0,
                Text = "Должность:",
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            _salaryLabel = new Label
            {
                AutoSize = true,
                Location = new Point(12, 44),
                Name = "salaryLabel",
                Size = new Size(44, 15),
                TabIndex = 4,
                Text = "Оклад:",
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            _agencyNameLabel = new Label
            {
                AutoSize = true,
                Location = new Point(12, 73),
                Name = "agencyNameLabel",
                Size = new Size(112, 15),
                TabIndex = 6,
                Text = "Название агенства:",
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            _positionTextBox = new TextBox
            {
                Location = new Point(130, 12),
                Name = "positionTextBox",
                Size = new Size(242, 23),
                TabIndex = 1,
                Anchor = AnchorStyles.Top | (AnchorStyles.Left | AnchorStyles.Right)
            };

            _salaryTextBox = new TextBox
            {
                Location = new Point(130, 41),
                Name = "salaryTextBox",
                Size = new Size(242, 23),
                TabIndex = 5,
                Anchor = AnchorStyles.Top | (AnchorStyles.Left | AnchorStyles.Right)
            };

            _agencyNameComboBox = new ComboBox
            {
                FormattingEnabled = true,
                Location = new Point(130, 70),
                Name = "agencyNameComboBox",
                Size = new Size(242, 23),
                TabIndex = 7,
                Anchor = AnchorStyles.Top | (AnchorStyles.Left | AnchorStyles.Right)
            };

            Name = "AddVacancyForm";
            Text = "Добавление вакансии";

            Controls.Add(_positionLabel);
            Controls.Add(_salaryLabel);
            Controls.Add(_agencyNameLabel);
            Controls.Add(_positionTextBox);
            Controls.Add(_salaryTextBox);
            Controls.Add(_agencyNameComboBox);
        }

        public VacancyModel NewModel
        {
            get
            {
                return new VacancyModel()
                {
                    Position = _positionTextBox.Text,
                    Salary = Convert.ToInt32(_salaryTextBox.Text),
                    AgencyName = _agencyNameComboBox.Text
                };
            }
        }

        public string[] Arguments
        {
            set => _agencyNameComboBox.Items.AddRange(value);
        }
    }
}
