
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.agenciesTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agencyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacanciesTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vacancyPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancySalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyAgencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.agenciesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.vacanciesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRecordBtn,
            this.editRecordBtn,
            this.removeRecordBtn});
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
            this.addNewRecordBtn.Click += new System.EventHandler(this.addNewRecordBtn_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.agenciesTabPage);
            this.tabControl1.Controls.Add(this.vacanciesTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 526);
            this.tabControl1.TabIndex = 1;
            // 
            // agenciesTabPage
            // 
            this.agenciesTabPage.Controls.Add(this.dataGridView1);
            this.agenciesTabPage.Location = new System.Drawing.Point(4, 24);
            this.agenciesTabPage.Name = "agenciesTabPage";
            this.agenciesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.agenciesTabPage.Size = new System.Drawing.Size(1042, 498);
            this.agenciesTabPage.TabIndex = 0;
            this.agenciesTabPage.Text = "Агенства";
            this.agenciesTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agencyNameColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // agencyNameColumn
            // 
            this.agencyNameColumn.HeaderText = "Название";
            this.agencyNameColumn.Name = "agencyNameColumn";
            // 
            // vacanciesTabPage
            // 
            this.vacanciesTabPage.Controls.Add(this.dataGridView2);
            this.vacanciesTabPage.Location = new System.Drawing.Point(4, 24);
            this.vacanciesTabPage.Name = "vacanciesTabPage";
            this.vacanciesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vacanciesTabPage.Size = new System.Drawing.Size(1042, 498);
            this.vacanciesTabPage.TabIndex = 1;
            this.vacanciesTabPage.Text = "Вакансии";
            this.vacanciesTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vacancyPositionColumn,
            this.vacancySalaryColumn,
            this.vacancyAgencyColumn});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1036, 492);
            this.dataGridView2.TabIndex = 1;
            // 
            // vacancyPositionColumn
            // 
            this.vacancyPositionColumn.HeaderText = "Должность";
            this.vacancyPositionColumn.Name = "vacancyPositionColumn";
            // 
            // vacancySalaryColumn
            // 
            this.vacancySalaryColumn.HeaderText = "Оклад";
            this.vacancySalaryColumn.Name = "vacancySalaryColumn";
            // 
            // vacancyAgencyColumn
            // 
            this.vacancyAgencyColumn.HeaderText = "Название агенства";
            this.vacancyAgencyColumn.Name = "vacancyAgencyColumn";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminMainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.agenciesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.vacanciesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage agenciesTabPage;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn agencyNameColumn;
		private System.Windows.Forms.TabPage vacanciesTabPage;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn vacancyPositionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vacancySalaryColumn;
		private System.Windows.Forms.ToolStripButton addNewRecordBtn;
		private System.Windows.Forms.ToolStripButton editRecordBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn vacancyAgencyColumn;
		private System.Windows.Forms.ToolStripButton removeRecordBtn;
	}
}

