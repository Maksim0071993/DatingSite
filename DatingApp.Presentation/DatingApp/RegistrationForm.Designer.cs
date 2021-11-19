
namespace DatingApp.Presentation.WindowsForm
{
    partial class RegistrationForm
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
            this._eMailRegistrationTextBox = new System.Windows.Forms.TextBox();
            this._passwordRegistrationTextBox = new System.Windows.Forms.TextBox();
            this._emailLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._registrationLabel = new System.Windows.Forms.Label();
            this._registrationButton = new System.Windows.Forms.Button();
            this._confirmPasswordLabel = new System.Windows.Forms.Label();
            this._confirmPasswordRegistrationTextBox = new System.Windows.Forms.TextBox();
            this._goToLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _eMailRegistrationTextBox
            // 
            this._eMailRegistrationTextBox.Location = new System.Drawing.Point(301, 142);
            this._eMailRegistrationTextBox.Name = "_eMailRegistrationTextBox";
            this._eMailRegistrationTextBox.Size = new System.Drawing.Size(178, 27);
            this._eMailRegistrationTextBox.TabIndex = 0;
            // 
            // _passwordRegistrationTextBox
            // 
            this._passwordRegistrationTextBox.Location = new System.Drawing.Point(301, 217);
            this._passwordRegistrationTextBox.Name = "_passwordRegistrationTextBox";
            this._passwordRegistrationTextBox.Size = new System.Drawing.Size(178, 27);
            this._passwordRegistrationTextBox.TabIndex = 1;
            // 
            // _emailLabel
            // 
            this._emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._emailLabel.Location = new System.Drawing.Point(163, 142);
            this._emailLabel.Name = "_emailLabel";
            this._emailLabel.Size = new System.Drawing.Size(64, 27);
            this._emailLabel.TabIndex = 2;
            this._emailLabel.Text = "E-mail";
            this._emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.Location = new System.Drawing.Point(163, 220);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(75, 20);
            this._passwordLabel.TabIndex = 3;
            this._passwordLabel.Text = "Password";
            // 
            // _registrationLabel
            // 
            this._registrationLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._registrationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._registrationLabel.Location = new System.Drawing.Point(-3, -2);
            this._registrationLabel.Name = "_registrationLabel";
            this._registrationLabel.Size = new System.Drawing.Size(810, 100);
            this._registrationLabel.TabIndex = 4;
            this._registrationLabel.Text = "Registration Window";
            this._registrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _registrationButton
            // 
            this._registrationButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this._registrationButton.Location = new System.Drawing.Point(299, 350);
            this._registrationButton.Name = "_registrationButton";
            this._registrationButton.Size = new System.Drawing.Size(179, 38);
            this._registrationButton.TabIndex = 5;
            this._registrationButton.Text = "Register";
            this._registrationButton.UseVisualStyleBackColor = false;
            this._registrationButton.Click += new System.EventHandler(this._registrationButton_Click);
            // 
            // _confirmPasswordLabel
            // 
            this._confirmPasswordLabel.AutoSize = true;
            this._confirmPasswordLabel.Location = new System.Drawing.Point(142, 294);
            this._confirmPasswordLabel.Name = "_confirmPasswordLabel";
            this._confirmPasswordLabel.Size = new System.Drawing.Size(127, 20);
            this._confirmPasswordLabel.TabIndex = 6;
            this._confirmPasswordLabel.Text = "Confirm Password";
            // 
            // _confirmPasswordRegistrationTextBox
            // 
            this._confirmPasswordRegistrationTextBox.Location = new System.Drawing.Point(300, 291);
            this._confirmPasswordRegistrationTextBox.Name = "_confirmPasswordRegistrationTextBox";
            this._confirmPasswordRegistrationTextBox.Size = new System.Drawing.Size(178, 27);
            this._confirmPasswordRegistrationTextBox.TabIndex = 7;
            // 
            // _goToLoginButton
            // 
            this._goToLoginButton.Location = new System.Drawing.Point(252, 416);
            this._goToLoginButton.Name = "_goToLoginButton";
            this._goToLoginButton.Size = new System.Drawing.Size(274, 35);
            this._goToLoginButton.TabIndex = 8;
            this._goToLoginButton.Text = "I have an account";
            this._goToLoginButton.UseVisualStyleBackColor = true;
            this._goToLoginButton.Click += new System.EventHandler(this._goToLoginButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._goToLoginButton);
            this.Controls.Add(this._confirmPasswordRegistrationTextBox);
            this.Controls.Add(this._confirmPasswordLabel);
            this.Controls.Add(this._registrationButton);
            this.Controls.Add(this._registrationLabel);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._emailLabel);
            this.Controls.Add(this._passwordRegistrationTextBox);
            this.Controls.Add(this._eMailRegistrationTextBox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _eMailRegistrationTextBox;
        private System.Windows.Forms.TextBox _passwordRegistrationTextBox;
        private System.Windows.Forms.Label _emailLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _registrationLabel;
        private System.Windows.Forms.Button _registrationButton;
        private System.Windows.Forms.Label _confirmPasswordLabel;
        private System.Windows.Forms.TextBox _confirmPasswordRegistrationTextBox;
        private System.Windows.Forms.Button _goToLoginButton;
    }
}

