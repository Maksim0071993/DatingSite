using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.Presentation.Interfaces;
using DatingApp.Presentation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp.Presentation.WindowsForm
{
    public partial class RegistrationForm : Form
    {
        private readonly IFormOpener _formOpener;
        private readonly IRegistrationService _registrationService;
        private readonly IProfileService _profileService;
        private readonly ProfileSelected _profileSelected;

        public RegistrationForm(IFormOpener formOpener, IRegistrationService registrationService, IProfileService profileService, ProfileSelected profileSelected)
        {
            InitializeComponent();
            _formOpener = formOpener;
            _registrationService = registrationService;
            _profileService = profileService;
            _profileSelected = profileSelected;
        }

        private void _registrationButton_Click(object sender, EventArgs e)
        {
            
            if (_passwordRegistrationTextBox.Text == _confirmPasswordRegistrationTextBox.Text)
            {
                int id = _registrationService.Register(_eMailRegistrationTextBox.Text.TrimEnd(), _passwordRegistrationTextBox.Text.TrimEnd());
                _profileSelected.RegistrationId = id;
                this.Hide();
                _formOpener.ShowModelessForm<ProfileForm>();
            }
            else
            {
                MessageBox.Show("Password mismatch");
            }
        }

        private void _goToLoginButton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            _formOpener.ShowModelessForm<LoginForm>();
        }
    }
}
