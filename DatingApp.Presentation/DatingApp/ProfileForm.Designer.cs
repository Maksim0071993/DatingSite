
namespace DatingApp.Presentation.WindowsForm
{
    partial class ProfileForm
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
            this._createProfileLabel = new System.Windows.Forms.Label();
            this._aboutMeTextBox = new System.Windows.Forms.TextBox();
            this._lastNameTextBox = new System.Windows.Forms.TextBox();
            this._ageTextBox = new System.Windows.Forms.TextBox();
            this._firstNameTextBox = new System.Windows.Forms.TextBox();
            this._firstNameLabel = new System.Windows.Forms.Label();
            this._lastNameLabel = new System.Windows.Forms.Label();
            this._ageLabel = new System.Windows.Forms.Label();
            this._aboutMeLabel = new System.Windows.Forms.Label();
            this._sexComboBox = new System.Windows.Forms.ComboBox();
            this._orientationComboBox = new System.Windows.Forms.ComboBox();
            this._sexLabel = new System.Windows.Forms.Label();
            this._orientationLabel = new System.Windows.Forms.Label();
            this._saveProfileButton = new System.Windows.Forms.Button();
            this._cityLabel = new System.Windows.Forms.Label();
            this._cityComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _createProfileLabel
            // 
            this._createProfileLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._createProfileLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._createProfileLabel.Location = new System.Drawing.Point(0, 0);
            this._createProfileLabel.Name = "_createProfileLabel";
            this._createProfileLabel.Size = new System.Drawing.Size(810, 70);
            this._createProfileLabel.TabIndex = 0;
            this._createProfileLabel.Text = "Create Profile";
            this._createProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _aboutMeTextBox
            // 
            this._aboutMeTextBox.Location = new System.Drawing.Point(593, 237);
            this._aboutMeTextBox.Name = "_aboutMeTextBox";
            this._aboutMeTextBox.Size = new System.Drawing.Size(151, 27);
            this._aboutMeTextBox.TabIndex = 1;
            // 
            // _lastNameTextBox
            // 
            this._lastNameTextBox.Location = new System.Drawing.Point(155, 160);
            this._lastNameTextBox.Name = "_lastNameTextBox";
            this._lastNameTextBox.Size = new System.Drawing.Size(155, 27);
            this._lastNameTextBox.TabIndex = 2;
            // 
            // _ageTextBox
            // 
            this._ageTextBox.Location = new System.Drawing.Point(155, 233);
            this._ageTextBox.Name = "_ageTextBox";
            this._ageTextBox.Size = new System.Drawing.Size(155, 27);
            this._ageTextBox.TabIndex = 3;
            // 
            // _firstNameTextBox
            // 
            this._firstNameTextBox.Location = new System.Drawing.Point(155, 88);
            this._firstNameTextBox.Name = "_firstNameTextBox";
            this._firstNameTextBox.Size = new System.Drawing.Size(155, 27);
            this._firstNameTextBox.TabIndex = 5;
            // 
            // _firstNameLabel
            // 
            this._firstNameLabel.Location = new System.Drawing.Point(41, 91);
            this._firstNameLabel.Name = "_firstNameLabel";
            this._firstNameLabel.Size = new System.Drawing.Size(89, 25);
            this._firstNameLabel.TabIndex = 6;
            this._firstNameLabel.Text = "First Name";
            // 
            // _lastNameLabel
            // 
            this._lastNameLabel.Location = new System.Drawing.Point(41, 163);
            this._lastNameLabel.Name = "_lastNameLabel";
            this._lastNameLabel.Size = new System.Drawing.Size(89, 25);
            this._lastNameLabel.TabIndex = 7;
            this._lastNameLabel.Text = "Last Name";
            // 
            // _ageLabel
            // 
            this._ageLabel.Location = new System.Drawing.Point(54, 233);
            this._ageLabel.Name = "_ageLabel";
            this._ageLabel.Size = new System.Drawing.Size(56, 25);
            this._ageLabel.TabIndex = 8;
            this._ageLabel.Text = "Age";
            // 
            // _aboutMeLabel
            // 
            this._aboutMeLabel.Location = new System.Drawing.Point(479, 240);
            this._aboutMeLabel.Name = "_aboutMeLabel";
            this._aboutMeLabel.Size = new System.Drawing.Size(89, 25);
            this._aboutMeLabel.TabIndex = 9;
            this._aboutMeLabel.Text = "About Me";
            // 
            // _sexComboBox
            // 
            this._sexComboBox.FormattingEnabled = true;
            this._sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._sexComboBox.Location = new System.Drawing.Point(593, 87);
            this._sexComboBox.Name = "_sexComboBox";
            this._sexComboBox.Size = new System.Drawing.Size(151, 28);
            this._sexComboBox.TabIndex = 10;
            // 
            // _orientationComboBox
            // 
            this._orientationComboBox.FormattingEnabled = true;
            this._orientationComboBox.Items.AddRange(new object[] {
            "Getero",
            "Bi",
            "Lesbi",
            "Gay"});
            this._orientationComboBox.Location = new System.Drawing.Point(593, 163);
            this._orientationComboBox.Name = "_orientationComboBox";
            this._orientationComboBox.Size = new System.Drawing.Size(151, 28);
            this._orientationComboBox.TabIndex = 11;
            // 
            // _sexLabel
            // 
            this._sexLabel.AutoSize = true;
            this._sexLabel.Location = new System.Drawing.Point(488, 90);
            this._sexLabel.Name = "_sexLabel";
            this._sexLabel.Size = new System.Drawing.Size(32, 20);
            this._sexLabel.TabIndex = 12;
            this._sexLabel.Text = "Sex";
            // 
            // _orientationLabel
            // 
            this._orientationLabel.AutoSize = true;
            this._orientationLabel.Location = new System.Drawing.Point(479, 167);
            this._orientationLabel.Name = "_orientationLabel";
            this._orientationLabel.Size = new System.Drawing.Size(84, 20);
            this._orientationLabel.TabIndex = 13;
            this._orientationLabel.Text = "Orientation";
            // 
            // _saveProfileButton
            // 
            this._saveProfileButton.Location = new System.Drawing.Point(275, 366);
            this._saveProfileButton.Name = "_saveProfileButton";
            this._saveProfileButton.Size = new System.Drawing.Size(237, 46);
            this._saveProfileButton.TabIndex = 14;
            this._saveProfileButton.Text = "Save Profile";
            this._saveProfileButton.UseVisualStyleBackColor = true;
            this._saveProfileButton.Click += new System.EventHandler(this._saveProfileButton_Click);
            // 
            // _cityLabel
            // 
            this._cityLabel.AutoSize = true;
            this._cityLabel.Location = new System.Drawing.Point(54, 303);
            this._cityLabel.Name = "_cityLabel";
            this._cityLabel.Size = new System.Drawing.Size(34, 20);
            this._cityLabel.TabIndex = 15;
            this._cityLabel.Text = "City";
            // 
            // _cityComboBox
            // 
            this._cityComboBox.FormattingEnabled = true;
            this._cityComboBox.Location = new System.Drawing.Point(155, 300);
            this._cityComboBox.Name = "_cityComboBox";
            this._cityComboBox.Size = new System.Drawing.Size(155, 28);
            this._cityComboBox.TabIndex = 17;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._cityComboBox);
            this.Controls.Add(this._cityLabel);
            this.Controls.Add(this._saveProfileButton);
            this.Controls.Add(this._orientationLabel);
            this.Controls.Add(this._sexLabel);
            this.Controls.Add(this._orientationComboBox);
            this.Controls.Add(this._sexComboBox);
            this.Controls.Add(this._aboutMeLabel);
            this.Controls.Add(this._ageLabel);
            this.Controls.Add(this._lastNameLabel);
            this.Controls.Add(this._firstNameLabel);
            this.Controls.Add(this._firstNameTextBox);
            this.Controls.Add(this._ageTextBox);
            this.Controls.Add(this._lastNameTextBox);
            this.Controls.Add(this._aboutMeTextBox);
            this.Controls.Add(this._createProfileLabel);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _createProfileLabel;
        private System.Windows.Forms.TextBox _aboutMeTextBox;
        private System.Windows.Forms.TextBox _lastNameTextBox;
        private System.Windows.Forms.TextBox _ageTextBox;
        private System.Windows.Forms.TextBox _firstNameTextBox;
        private System.Windows.Forms.Label _firstNameLabel;
        private System.Windows.Forms.Label _lastNameLabel;
        private System.Windows.Forms.Label _ageLabel;
        private System.Windows.Forms.Label _aboutMeLabel;
        private System.Windows.Forms.ComboBox _sexComboBox;
        private System.Windows.Forms.ComboBox _orientationComboBox;
        private System.Windows.Forms.Label _sexLabel;
        private System.Windows.Forms.Label _orientationLabel;
        private System.Windows.Forms.Button _saveProfileButton;
        private System.Windows.Forms.Label _cityLabel;
        private System.Windows.Forms.ComboBox _cityComboBox;
    }
}