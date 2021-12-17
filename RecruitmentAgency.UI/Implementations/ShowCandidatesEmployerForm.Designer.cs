namespace RecruitmentAgency.UI.Implementations
{
    partial class ShowCandidatesEmployerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCandidatesEmployerForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.acceptBtn = new System.Windows.Forms.ToolStripButton();
            this.declineBtn = new System.Windows.Forms.ToolStripButton();
            this.printBtn = new System.Windows.Forms.ToolStripButton();
            this.initialsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceptBtn,
            this.declineBtn,
            this.printBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.initialsColumn,
            this.dateOfBirthColumn});
            this.dataGridView1.Location = new System.Drawing.Point(19, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(762, 386);
            this.dataGridView1.TabIndex = 3;
            // 
            // acceptBtn
            // 
            this.acceptBtn.AutoSize = false;
            this.acceptBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.acceptBtn.Image = ((System.Drawing.Image)(resources.GetObject("acceptBtn.Image")));
            this.acceptBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(32, 32);
            this.acceptBtn.Text = "toolStripButton1";
            this.acceptBtn.ToolTipText = "Выбрать кандидата";
            // 
            // declineBtn
            // 
            this.declineBtn.AutoSize = false;
            this.declineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.declineBtn.Image = ((System.Drawing.Image)(resources.GetObject("declineBtn.Image")));
            this.declineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(32, 32);
            this.declineBtn.Text = "toolStripButton2";
            this.declineBtn.ToolTipText = "Отклонить кандидата";
            // 
            // printBtn
            // 
            this.printBtn.AutoSize = false;
            this.printBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(32, 32);
            this.printBtn.Text = "toolStripButton3";
            this.printBtn.ToolTipText = "Распечатать анкету кандидата";
            // 
            // initialsColumn
            // 
            this.initialsColumn.HeaderText = "ФИО";
            this.initialsColumn.Name = "initialsColumn";
            // 
            // dateOfBirthColumn
            // 
            this.dateOfBirthColumn.HeaderText = "Дата рождения";
            this.dateOfBirthColumn.Name = "dateOfBirthColumn";
            // 
            // ShowCandidatesEmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ShowCandidatesEmployerForm";
            this.Text = "Кандидаты на вакансию";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton acceptBtn;
        private System.Windows.Forms.ToolStripButton declineBtn;
        private System.Windows.Forms.ToolStripButton printBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthColumn;
    }
}