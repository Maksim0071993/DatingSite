
namespace DatingApp.Presentation.WindowsForm
{
    partial class CorrespondenceForm
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
            this._correspondenceLabel = new System.Windows.Forms.Label();
            this._sendMessageButton = new System.Windows.Forms.Button();
            this._messageTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._TabPage = new System.Windows.Forms.TabPage();
            this._tablesListView = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._listViewSendedMessage = new System.Windows.Forms.ListView();
            this._recepientComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this._TabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _correspondenceLabel
            // 
            this._correspondenceLabel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._correspondenceLabel.Location = new System.Drawing.Point(-5, -3);
            this._correspondenceLabel.Name = "_correspondenceLabel";
            this._correspondenceLabel.Size = new System.Drawing.Size(811, 45);
            this._correspondenceLabel.TabIndex = 0;
            this._correspondenceLabel.Text = "Dialog Box";
            this._correspondenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _sendMessageButton
            // 
            this._sendMessageButton.Location = new System.Drawing.Point(678, 385);
            this._sendMessageButton.Name = "_sendMessageButton";
            this._sendMessageButton.Size = new System.Drawing.Size(128, 71);
            this._sendMessageButton.TabIndex = 1;
            this._sendMessageButton.Text = "Send Message";
            this._sendMessageButton.UseVisualStyleBackColor = true;
            this._sendMessageButton.Click += new System.EventHandler(this._sendMessageButton_Click);
            // 
            // _messageTextBox
            // 
            this._messageTextBox.Location = new System.Drawing.Point(307, 385);
            this._messageTextBox.Multiline = true;
            this._messageTextBox.Name = "_messageTextBox";
            this._messageTextBox.Size = new System.Drawing.Size(365, 71);
            this._messageTextBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._TabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(314, 334);
            this.tabControl1.TabIndex = 4;
            // 
            // _TabPage
            // 
            this._TabPage.Controls.Add(this._tablesListView);
            this._TabPage.Location = new System.Drawing.Point(4, 29);
            this._TabPage.Name = "_TabPage";
            this._TabPage.Padding = new System.Windows.Forms.Padding(3);
            this._TabPage.Size = new System.Drawing.Size(306, 301);
            this._TabPage.TabIndex = 0;
            this._TabPage.Text = "Incoming messages";
            this._TabPage.UseVisualStyleBackColor = true;
            // 
            // _tablesListView
            // 
            this._tablesListView.HideSelection = false;
            this._tablesListView.Location = new System.Drawing.Point(6, 0);
            this._tablesListView.Name = "_tablesListView";
            this._tablesListView.Size = new System.Drawing.Size(300, 298);
            this._tablesListView.TabIndex = 5;
            this._tablesListView.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._listViewSendedMessage);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(306, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "outgoing messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _listViewSendedMessage
            // 
            this._listViewSendedMessage.HideSelection = false;
            this._listViewSendedMessage.Location = new System.Drawing.Point(3, 3);
            this._listViewSendedMessage.Name = "_listViewSendedMessage";
            this._listViewSendedMessage.Size = new System.Drawing.Size(303, 298);
            this._listViewSendedMessage.TabIndex = 6;
            this._listViewSendedMessage.UseCompatibleStateImageBehavior = false;
            // 
            // _recepientComboBox
            // 
            this._recepientComboBox.FormattingEnabled = true;
            this._recepientComboBox.Location = new System.Drawing.Point(-1, 385);
            this._recepientComboBox.Name = "_recepientComboBox";
            this._recepientComboBox.Size = new System.Drawing.Size(302, 28);
            this._recepientComboBox.TabIndex = 5;
            // 
            // CorrespondenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._recepientComboBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._messageTextBox);
            this.Controls.Add(this._sendMessageButton);
            this.Controls.Add(this._correspondenceLabel);
            this.Name = "CorrespondenceForm";
            this.Text = "CorrespondenceForm";
            this.Shown += new System.EventHandler(this.CorrespondenceForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this._TabPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _correspondenceLabel;
        private System.Windows.Forms.Button _sendMessageButton;
        private System.Windows.Forms.TextBox _messageTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _TabPage;
        private System.Windows.Forms.ListView _tablesListView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox _recepientComboBox;
        private System.Windows.Forms.ListView _listViewSendedMessage;
    }
}