using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.Common;
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
    public partial class ProfileForm : Form
    {
        private readonly IProfileService _profileService;
        private readonly IFormOpener _formOpener;
        private readonly ProfileSelected _profile;
        private readonly ILookupValueService _lookupValueService;
        public ProfileForm(IProfileService profileService, IFormOpener formOpener, ProfileSelected profile, ILookupValueService lookupValueService)
        {
            _profile = profile;
            _profileService = profileService;
            InitializeComponent();
            _formOpener = formOpener;
            _lookupValueService = lookupValueService;

            _cityComboBox.DisplayMember = "Title";
            _cityComboBox.ValueMember = "Id";

            _cityComboBox.Items.AddRange(_lookupValueService.GetByCode("City").ToArray());
            
        }        
        private void _saveProfileButton_Click(object sender, EventArgs e)
        {
            int age = int.Parse(_ageTextBox.Text);
            if (_firstNameTextBox.Text != null && _sexComboBox.Text != null && _ageTextBox.Text != "")
            {
                ProfileModel profileModel = new ProfileModel()
                {
                    Id = _profile.RegistrationId,
                    FirstName = _firstNameTextBox.Text,
                    LastName = _lastNameTextBox.Text,
                    Age = age,
                    Sex = (Sex)_sexComboBox.SelectedIndex,
                    Orientation = (Orientations)_orientationComboBox.SelectedIndex,
                    AboutMe = _aboutMeTextBox.Text,
                    CityId = ((LookupValueModel)_cityComboBox.SelectedItem).Id
                };
                _profile.Profile = profileModel;
                _profileService.CreateProfile(profileModel);
                this.Hide();
                //_formOpener.ShowModelessForm<SearchForm>();
                _formOpener.ShowModelessForm<CorrespondenceForm>(_profile.Profile.Id);
            }
            else
            {
                MessageBox.Show("Fields First Name, Age, City, Sex must be filled");
            }
            
        }
    }       
}
