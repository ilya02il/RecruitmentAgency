
namespace RecruitmentAgency.UI.Implementations
{
    partial class LoginForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.registrationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(16, 23);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин: ";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(92, 18);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(237, 27);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(92, 58);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(237, 27);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 63);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль: ";
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(116, 172);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(100, 35);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "ОК";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Еще не зарегистрированы?";
            // 
            // registrationLinkLabel
            // 
            this.registrationLinkLabel.AutoSize = true;
            this.registrationLinkLabel.Location = new System.Drawing.Point(92, 142);
            this.registrationLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registrationLinkLabel.Name = "registrationLinkLabel";
            this.registrationLinkLabel.Size = new System.Drawing.Size(151, 20);
            this.registrationLinkLabel.TabIndex = 9;
            this.registrationLinkLabel.TabStop = true;
            this.registrationLinkLabel.Text = "Зарегистрироваться";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 225);
            this.Controls.Add(this.registrationLinkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel registrationLinkLabel;
    }
}