using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.Presentation.Services;
using DatingApp.Presentation.Services.Interfaces;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DatingApp.Presentation.WindowsForm
{
    public partial class CorrespondenceForm : Form
    {
        private readonly IChatService _chatService;
        private readonly IProfileService _profileService;
        private readonly ProfileSelected _profile;
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        public CorrespondenceForm( IChatService chatService, IProfileService profileService, ProfileSelected profile)
        {
            _profileService = profileService;
            _chatService = chatService;
            _profile = profile;           
            InitializeComponent();
            
        }
        
        void TimerEvent(Object myObject, EventArgs ev)
        {
            _tablesListView.Clear();
            _listViewSendedMessage.Clear();
            GetAllMessages();
        }
        public void UseTimer()
        {
            _timer.Interval = 10000;
            _timer.Tick += TimerEvent;
            _timer.Start();
        }
        private void GetAllMessages()
        {
            UseTimer();
            var allProfiles = _profileService.GetAll();
            _recepientComboBox.DisplayMember = "FirstName";
            _recepientComboBox.ValueMember = "Id";

            for (int i = 0; i < allProfiles.Count; i++)
            {
                _recepientComboBox.Items.Add(allProfiles[i]);
            }

            var reciviedMessages = _chatService.GetReceivedMesaages(_profile.Profile.Id);

            foreach (var message in reciviedMessages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = message.SenderName + " : " + message.TextMessage;
                _tablesListView.Items.Add(lvi);
            }

            var sendMessages = _chatService.GetSendedMesaages(_profile.Profile.Id);
            foreach (var mess in sendMessages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = mess.RecipientName + " : " + mess.TextMessage;
                _listViewSendedMessage.Items.Add(lvi);
            }
        }

        private void _sendMessageButton_Click(object sender, EventArgs e)
        {
            if (_messageTextBox.Text != string.Empty)
            {
                _chatService.SendMessage(_messageTextBox.Text, (ProfileModel)_recepientComboBox.SelectedItem, new ProfileModel { Id = _profile.Profile.Id });
                ListViewItem lvi = new ListViewItem();
                var sendedPerson = (ProfileModel)_recepientComboBox.SelectedItem;
                lvi.Text = sendedPerson.FirstName + " : " + _messageTextBox.Text;
                _listViewSendedMessage.Items.Add(lvi);
                _messageTextBox.Clear();
            }
        }
        private void CorrespondenceForm_Shown(object sender, EventArgs e)
        {
            GetAllMessages();
        }
    }
}
