
namespace RecruitmentAgency.UI
{
	partial class AdminMainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNewRecordBtn = new System.Windows.Forms.ToolStripButton();
            this.editRecordBtn = new System.Windows.Forms.ToolStripButton();
            this.removeRecordBtn = new System.Windows.Forms.ToolStripButton();
            this.showCandidatesBtn = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vacanciesTabPage = new System.Windows.Forms.TabPage();
            this.vacanciesDataGridView = new System.Windows.Forms.DataGridView();
            this.vacancyEmployerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancySalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employersTabPage = new System.Windows.Forms.TabPage();
            this.employersDataGridView = new System.Windows.Forms.DataGridView();
            this.organizationNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.vacanciesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesDataGridView)).BeginInit();
            this.employersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRecordBtn,
            this.editRecordBtn,
            this.removeRecordBtn,
            this.showCandidatesBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addNewRecordBtn
            // 
            this.addNewRecordBtn.AutoSize = false;
            this.addNewRecordBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewRecordBtn.Image = ((System.Drawing.Image)(resources.GetObject("addNewRecordBtn.Image")));
            this.addNewRecordBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewRecordBtn.Name = "addNewRecordBtn";
            this.addNewRecordBtn.Size = new System.Drawing.Size(32, 32);
            this.addNewRecordBtn.Text = "toolStripButton1";
            // 
            // editRecordBtn
            // 
            this.editRecordBtn.AutoSize = false;
            this.editRecordBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editRecordBtn.Image = ((System.Drawing.Image)(resources.GetObject("editRecordBtn.Image")));
            this.editRecordBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editRecordBtn.Name = "editRecordBtn";
            this.editRecordBtn.Size = new System.Drawing.Size(32, 32);
            this.editRecordBtn.Text = "toolStripButton2";
            this.editRecordBtn.Click += new System.EventHandler(this.editRecordBtn_Click);
            // 
            // removeRecordBtn
            // 
            this.removeRecordBtn.AutoSize = false;
            this.removeRecordBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeRecordBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeRecordBtn.Image")));
            this.removeRecordBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeRecordBtn.Name = "removeRecordBtn";
            this.removeRecordBtn.Size = new System.Drawing.Size(32, 32);
            this.removeRecordBtn.Text = "toolStripButton3";
            this.removeRecordBtn.Click += new System.EventHandler(this.removeRecordBtn_Click);
            // 
            // showCandidatesBtn
            // 
            this.showCandidatesBtn.AutoSize = false;
            this.showCandidatesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showCandidatesBtn.Image = ((System.Drawing.Image)(resources.GetObject("showCandidatesBtn.Image")));
            this.showCandidatesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showCandidatesBtn.Name = "showCandidatesBtn";
            this.showCandidatesBtn.Size = new System.Drawing.Size(32, 32);
            this.showCandidatesBtn.Text = "toolStripButton1";
            this.showCandidatesBtn.Click += new System.EventHandler(this.showCandidatesBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.vacanciesTabPage);
            this.tabControl1.Controls.Add(this.employersTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 526);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // vacanciesTabPage
            // 
            this.vacanciesTabPage.Controls.Add(this.vacanciesDataGridView);
            this.vacanciesTabPage.Location = new System.Drawing.Point(4, 24);
            this.vacanciesTabPage.Name = "vacanciesTabPage";
            this.vacanciesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vacanciesTabPage.Size = new System.Drawing.Size(1042, 498);
            this.vacanciesTabPage.TabIndex = 1;
            this.vacanciesTabPage.Text = "Вакансии";
            this.vacanciesTabPage.UseVisualStyleBackColor = true;
            // 
            // vacanciesDataGridView
            // 
            this.vacanciesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vacanciesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vacanciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacanciesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vacancyEmployerColumn,
            this.vacancyPositionColumn,
            this.vacancySalaryColumn});
            this.vacanciesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.vacanciesDataGridView.Name = "vacanciesDataGridView";
            this.vacanciesDataGridView.RowHeadersVisible = false;
            this.vacanciesDataGridView.RowHeadersWidth = 51;
            this.vacanciesDataGridView.RowTemplate.Height = 25;
            this.vacanciesDataGridView.Size = new System.Drawing.Size(1036, 492);
            this.vacanciesDataGridView.TabIndex = 1;
            // 
            // vacancyEmployerColumn
            // 
            this.vacancyEmployerColumn.HeaderText = "Работодатель";
            this.vacancyEmployerColumn.MinimumWidth = 6;
            this.vacancyEmployerColumn.Name = "vacancyEmployerColumn";
            // 
            // vacancyPositionColumn
            // 
            this.vacancyPositionColumn.HeaderText = "Должность";
            this.vacancyPositionColumn.MinimumWidth = 6;
            this.vacancyPositionColumn.Name = "vacancyPositionColumn";
            // 
            // vacancySalaryColumn
            // 
            this.vacancySalaryColumn.HeaderText = "Оклад";
            this.vacancySalaryColumn.MinimumWidth = 6;
            this.vacancySalaryColumn.Name = "vacancySalaryColumn";
            // 
            // employersTabPage
            // 
            this.employersTabPage.Controls.Add(this.employersDataGridView);
            this.employersTabPage.Location = new System.Drawing.Point(4, 24);
            this.employersTabPage.Name = "employersTabPage";
            this.employersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employersTabPage.Size = new System.Drawing.Size(1042, 498);
            this.employersTabPage.TabIndex = 2;
            this.employersTabPage.Text = "Работодатели";
            this.employersTabPage.UseVisualStyleBackColor = true;
            // 
            // employersDataGridView
            // 
            this.employersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.organizationNameColumn});
            this.employersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.employersDataGridView.Name = "employersDataGridView";
            this.employersDataGridView.RowHeadersVisible = false;
            this.employersDataGridView.RowTemplate.Height = 25;
            this.employersDataGridView.Size = new System.Drawing.Size(1036, 492);
            this.employersDataGridView.TabIndex = 0;
            // 
            // organizationNameColumn
            // 
            this.organizationNameColumn.HeaderText = "Название организации";
            this.organizationNameColumn.Name = "organizationNameColumn";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminMainForm";
            this.Text = "Агентство по трудоустройству";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.vacanciesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesDataGridView)).EndInit();
            this.employersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage vacanciesTabPage;
		private System.Windows.Forms.DataGridView vacanciesDataGridView;
		private System.Windows.Forms.ToolStripButton addNewRecordBtn;
		private System.Windows.Forms.ToolStripButton editRecordBtn;
		private System.Windows.Forms.ToolStripButton removeRecordBtn;
        private System.Windows.Forms.TabPage employersTabPage;
        private System.Windows.Forms.DataGridView employersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyEmployerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyPositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancySalaryColumn;
        private System.Windows.Forms.ToolStripButton showCandidatesBtn;
    }
}

