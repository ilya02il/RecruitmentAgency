namespace RecruitmentAgency.UI.Implementations
{
    partial class CandidateMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateMainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.respondBtn = new System.Windows.Forms.ToolStripButton();
            this.vacanciesDataGridView = new System.Windows.Forms.DataGridView();
            this.vacancyEmployerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancyPositionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacancySalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respondBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 35);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // respondBtn
            // 
            this.respondBtn.AutoSize = false;
            this.respondBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.respondBtn.Image = ((System.Drawing.Image)(resources.GetObject("respondBtn.Image")));
            this.respondBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.respondBtn.Name = "respondBtn";
            this.respondBtn.Size = new System.Drawing.Size(32, 32);
            this.respondBtn.Text = "toolStripButton1";
            this.respondBtn.ToolTipText = "Откликнуться";
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
            this.vacanciesDataGridView.Location = new System.Drawing.Point(12, 38);
            this.vacanciesDataGridView.Name = "vacanciesDataGridView";
            this.vacanciesDataGridView.RowHeadersVisible = false;
            this.vacanciesDataGridView.RowHeadersWidth = 51;
            this.vacanciesDataGridView.RowTemplate.Height = 25;
            this.vacanciesDataGridView.Size = new System.Drawing.Size(1026, 511);
            this.vacanciesDataGridView.TabIndex = 4;
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
            // CandidateMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.vacanciesDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CandidateMainForm";
            this.Text = "Вакансии";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton respondBtn;
        private System.Windows.Forms.DataGridView vacanciesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyEmployerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancyPositionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacancySalaryColumn;
    }
}