
namespace DatingApp.Presentation.WindowsForm
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
            this._loginLabel = new System.Windows.Forms.Label();
            this._emailLoginTextBox = new System.Windows.Forms.TextBox();
            this._passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this._emailLabelLogin = new System.Windows.Forms.Label();
            this._passwordTextBoxLogin = new System.Windows.Forms.Label();
            this._loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _loginLabel
            // 
            this._loginLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._loginLabel.Location = new System.Drawing.Point(-7, -2);
            this._loginLabel.Name = "_loginLabel";
            this._loginLabel.Size = new System.Drawing.Size(810, 100);
            this._loginLabel.TabIndex = 0;
            this._loginLabel.Text = "Login Window";
            this._loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _emailLoginTextBox
            // 
            this._emailLoginTextBox.Location = new System.Drawing.Point(318, 160);
            this._emailLoginTextBox.Name = "_emailLoginTextBox";
            this._emailLoginTextBox.Size = new System.Drawing.Size(212, 27);
            this._emailLoginTextBox.TabIndex = 1;
            this._emailLoginTextBox.Text = "Admin";
            // 
            // _passwordLoginTextBox
            // 
            this._passwordLoginTextBox.Location = new System.Drawing.Point(318, 250);
            this._passwordLoginTextBox.Name = "_passwordLoginTextBox";
            this._passwordLoginTextBox.Size = new System.Drawing.Size(212, 27);
            this._passwordLoginTextBox.TabIndex = 2;
            this._passwordLoginTextBox.Text = "Password";
            // 
            // _emailLabelLogin
            // 
            this._emailLabelLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._emailLabelLogin.Location = new System.Drawing.Point(200, 162);
            this._emailLabelLogin.Name = "_emailLabelLogin";
            this._emailLabelLogin.Size = new System.Drawing.Size(69, 25);
            this._emailLabelLogin.TabIndex = 3;
            this._emailLabelLogin.Text = "E:Mail";
            // 
            // _passwordTextBoxLogin
            // 
            this._passwordTextBoxLogin.AutoSize = true;
            this._passwordTextBoxLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._passwordTextBoxLogin.Location = new System.Drawing.Point(189, 254);
            this._passwordTextBoxLogin.Name = "_passwordTextBoxLogin";
            this._passwordTextBoxLogin.Size = new System.Drawing.Size(80, 23);
            this._passwordTextBoxLogin.TabIndex = 4;
            this._passwordTextBoxLogin.Text = "Password";
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(318, 366);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(212, 45);
            this._loginButton.TabIndex = 5;
            this._loginButton.Text = "Login";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this._loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._passwordTextBoxLogin);
            this.Controls.Add(this._emailLabelLogin);
            this.Controls.Add(this._passwordLoginTextBox);
            this.Controls.Add(this._emailLoginTextBox);
            this.Controls.Add(this._loginLabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _loginLabel;
        private System.Windows.Forms.TextBox _emailLoginTextBox;
        private System.Windows.Forms.TextBox _passwordLoginTextBox;
        private System.Windows.Forms.Label _emailLabelLogin;
        private System.Windows.Forms.Label _passwordTextBoxLogin;
        private System.Windows.Forms.Button _loginButton;
    }
}