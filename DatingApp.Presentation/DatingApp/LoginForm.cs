using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.Presentation.Interfaces;
using DatingApp.Presentation.Services;
using DatingApp.Presentation.Services.Interfaces;
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
    public partial class LoginForm : Form
    {
        private readonly IFormOpener _formOpener;
        IUserService _userService;
        ProfileSelected _profile;
        IProfileService _profileService;
        public LoginForm(IFormOpener formOpener, IUserService userService, ProfileSelected profile, IProfileService profileService)
        {
            InitializeComponent();
            _formOpener = formOpener;
            _userService = userService;
            _profile = profile;
            _profileService = profileService;
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            var result = _userService.SearchUser(_emailLoginTextBox.Text, _passwordLoginTextBox.Text);
            if (result != null)
            {
                this.Close();
                _formOpener.ShowModelessForm<CorrespondenceForm>(result.UserId);
                //_formOpener.ShowModelessForm<SearchForm>();
                _profile.Profile = _profileService.GetById(result.UserId);
            }
            else
            {
                this.Close();
                _formOpener.ShowModelessForm<SearchForm>();
            }
        }
    }
}
