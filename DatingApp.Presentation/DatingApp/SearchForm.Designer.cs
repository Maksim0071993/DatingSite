
namespace DatingApp.Presentation.WindowsForm
{
    partial class SearchForm
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
            this._searchFormLabel = new System.Windows.Forms.Label();
            this._ageFromSearchTextBox = new System.Windows.Forms.TextBox();
            this._ageToSearchTextBox = new System.Windows.Forms.TextBox();
            this._firstNameSearchTextBox = new System.Windows.Forms.TextBox();
            this._ageSearchLabel = new System.Windows.Forms.Label();
            this._toSearchLabel = new System.Windows.Forms.Label();
            this._citySearchLabel = new System.Windows.Forms.Label();
            this._firstNameSearchLabel = new System.Windows.Forms.Label();
            this._sexSearchLabel = new System.Windows.Forms.Label();
            this._orientationSearchLabel = new System.Windows.Forms.Label();
            this._searchButton = new System.Windows.Forms.Button();
            this._sexSearchComboBox = new System.Windows.Forms.ComboBox();
            this._orientationSearchComboBox = new System.Windows.Forms.ComboBox();
            this._listBoxAfterSearch = new System.Windows.Forms.ListBox();
            this._cityComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _searchFormLabel
            // 
            this._searchFormLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._searchFormLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._searchFormLabel.Location = new System.Drawing.Point(0, 0);
            this._searchFormLabel.Name = "_searchFormLabel";
            this._searchFormLabel.Size = new System.Drawing.Size(782, 78);
            this._searchFormLabel.TabIndex = 0;
            this._searchFormLabel.Text = "Search";
            this._searchFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _ageFromSearchTextBox
            // 
            this._ageFromSearchTextBox.Location = new System.Drawing.Point(127, 142);
            this._ageFromSearchTextBox.Name = "_ageFromSearchTextBox";
            this._ageFromSearchTextBox.Size = new System.Drawing.Size(145, 27);
            this._ageFromSearchTextBox.TabIndex = 1;
            // 
            // _ageToSearchTextBox
            // 
            this._ageToSearchTextBox.Location = new System.Drawing.Point(348, 140);
            this._ageToSearchTextBox.Name = "_ageToSearchTextBox";
            this._ageToSearchTextBox.Size = new System.Drawing.Size(154, 27);
            this._ageToSearchTextBox.TabIndex = 2;
            // 
            // _firstNameSearchTextBox
            // 
            this._firstNameSearchTextBox.Location = new System.Drawing.Point(127, 81);
            this._firstNameSearchTextBox.Name = "_firstNameSearchTextBox";
            this._firstNameSearchTextBox.Size = new System.Drawing.Size(145, 27);
            this._firstNameSearchTextBox.TabIndex = 4;
            // 
            // _ageSearchLabel
            // 
            this._ageSearchLabel.AutoSize = true;
            this._ageSearchLabel.Location = new System.Drawing.Point(12, 143);
            this._ageSearchLabel.Name = "_ageSearchLabel";
            this._ageSearchLabel.Size = new System.Drawing.Size(90, 20);
            this._ageSearchLabel.TabIndex = 5;
            this._ageSearchLabel.Text = "Age     From";
            // 
            // _toSearchLabel
            // 
            this._toSearchLabel.AutoSize = true;
            this._toSearchLabel.Location = new System.Drawing.Point(286, 143);
            this._toSearchLabel.Name = "_toSearchLabel";
            this._toSearchLabel.Size = new System.Drawing.Size(25, 20);
            this._toSearchLabel.TabIndex = 6;
            this._toSearchLabel.Text = "To";
            // 
            // _citySearchLabel
            // 
            this._citySearchLabel.AutoSize = true;
            this._citySearchLabel.Location = new System.Drawing.Point(12, 212);
            this._citySearchLabel.Name = "_citySearchLabel";
            this._citySearchLabel.Size = new System.Drawing.Size(34, 20);
            this._citySearchLabel.TabIndex = 7;
            this._citySearchLabel.Text = "City";
            // 
            // _firstNameSearchLabel
            // 
            this._firstNameSearchLabel.AutoSize = true;
            this._firstNameSearchLabel.Location = new System.Drawing.Point(12, 84);
            this._firstNameSearchLabel.Name = "_firstNameSearchLabel";
            this._firstNameSearchLabel.Size = new System.Drawing.Size(80, 20);
            this._firstNameSearchLabel.TabIndex = 8;
            this._firstNameSearchLabel.Text = "First Name";
            // 
            // _sexSearchLabel
            // 
            this._sexSearchLabel.AutoSize = true;
            this._sexSearchLabel.Location = new System.Drawing.Point(12, 277);
            this._sexSearchLabel.Name = "_sexSearchLabel";
            this._sexSearchLabel.Size = new System.Drawing.Size(32, 20);
            this._sexSearchLabel.TabIndex = 11;
            this._sexSearchLabel.Text = "Sex";
            // 
            // _orientationSearchLabel
            // 
            this._orientationSearchLabel.AutoSize = true;
            this._orientationSearchLabel.Location = new System.Drawing.Point(12, 337);
            this._orientationSearchLabel.Name = "_orientationSearchLabel";
            this._orientationSearchLabel.Size = new System.Drawing.Size(84, 20);
            this._orientationSearchLabel.TabIndex = 12;
            this._orientationSearchLabel.Text = "Orientation";
            // 
            // _searchButton
            // 
            this._searchButton.Location = new System.Drawing.Point(700, 113);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(98, 283);
            this._searchButton.TabIndex = 13;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _sexSearchComboBox
            // 
            this._sexSearchComboBox.FormattingEnabled = true;
            this._sexSearchComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this._sexSearchComboBox.Location = new System.Drawing.Point(127, 274);
            this._sexSearchComboBox.Name = "_sexSearchComboBox";
            this._sexSearchComboBox.Size = new System.Drawing.Size(145, 28);
            this._sexSearchComboBox.TabIndex = 14;
            // 
            // _orientationSearchComboBox
            // 
            this._orientationSearchComboBox.FormattingEnabled = true;
            this._orientationSearchComboBox.Items.AddRange(new object[] {
            "Getero",
            "Bi",
            "Lesbi",
            "Gay"});
            this._orientationSearchComboBox.Location = new System.Drawing.Point(127, 334);
            this._orientationSearchComboBox.Name = "_orientationSearchComboBox";
            this._orientationSearchComboBox.Size = new System.Drawing.Size(145, 28);
            this._orientationSearchComboBox.TabIndex = 15;
            // 
            // _listBoxAfterSearch
            // 
            this._listBoxAfterSearch.FormattingEnabled = true;
            this._listBoxAfterSearch.ItemHeight = 20;
            this._listBoxAfterSearch.Location = new System.Drawing.Point(335, 198);
            this._listBoxAfterSearch.Name = "_listBoxAfterSearch";
            this._listBoxAfterSearch.Size = new System.Drawing.Size(306, 184);
            this._listBoxAfterSearch.TabIndex = 16;
            // 
            // _cityComboBox
            // 
            this._cityComboBox.FormattingEnabled = true;
            this._cityComboBox.Location = new System.Drawing.Point(127, 209);
            this._cityComboBox.Name = "_cityComboBox";
            this._cityComboBox.Size = new System.Drawing.Size(145, 28);
            this._cityComboBox.TabIndex = 17;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._cityComboBox);
            this.Controls.Add(this._listBoxAfterSearch);
            this.Controls.Add(this._orientationSearchComboBox);
            this.Controls.Add(this._sexSearchComboBox);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this._orientationSearchLabel);
            this.Controls.Add(this._sexSearchLabel);
            this.Controls.Add(this._firstNameSearchLabel);
            this.Controls.Add(this._citySearchLabel);
            this.Controls.Add(this._toSearchLabel);
            this.Controls.Add(this._ageSearchLabel);
            this.Controls.Add(this._firstNameSearchTextBox);
            this.Controls.Add(this._ageToSearchTextBox);
            this.Controls.Add(this._ageFromSearchTextBox);
            this.Controls.Add(this._searchFormLabel);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _searchFormLabel;
        private System.Windows.Forms.TextBox _ageFromSearchTextBox;
        private System.Windows.Forms.TextBox _ageToSearchTextBox;
        private System.Windows.Forms.TextBox _firstNameSearchTextBox;
        private System.Windows.Forms.Label _ageSearchLabel;
        private System.Windows.Forms.Label _toSearchLabel;
        private System.Windows.Forms.Label _citySearchLabel;
        private System.Windows.Forms.Label _firstNameSearchLabel;
        private System.Windows.Forms.Label _sexSearchLabel;
        private System.Windows.Forms.Label _orientationSearchLabel;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.ComboBox _sexSearchComboBox;
        private System.Windows.Forms.ComboBox _orientationSearchComboBox;
        private System.Windows.Forms.ListBox _listBoxAfterSearch;
        private System.Windows.Forms.ComboBox _cityComboBox;
    }
}