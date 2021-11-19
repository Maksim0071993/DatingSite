using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.Common;
using DatingApp.DataAccessLayer.Repositories;
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
    public partial class SearchForm : Form
    {
        private readonly ISearchService _searchService;
        private readonly ILookupValueService _lookupValueService;
        public SearchForm(ISearchService searchService,ILookupValueService lookupValueService)
        {
            InitializeComponent();
            _listBoxAfterSearch.Items.Clear();
            _searchService = searchService;
            _lookupValueService = lookupValueService;
            _cityComboBox.DisplayMember = "Title";
            _cityComboBox.ValueMember = "Id";
            _cityComboBox.Items.AddRange(_lookupValueService.GetByCode("City").ToArray());
        }

        private void _searchButton_Click(object sender, EventArgs e)
        {
            _listBoxAfterSearch.Items.Clear();
            int? ageFrom;
            int? ageTo;
            if (_ageFromSearchTextBox.Text != "" && _ageToSearchTextBox.Text == "")
            {
                 ageFrom = int.Parse(_ageFromSearchTextBox.Text);
                ageTo = 999;
            }
            else if (_ageFromSearchTextBox.Text == "" && _ageToSearchTextBox.Text != "")
            {
                ageFrom = 0;
                ageTo = int.Parse(_ageToSearchTextBox.Text);
            }
            else if(_ageFromSearchTextBox.Text != "" && _ageToSearchTextBox.Text != "")
            {
                ageFrom = int.Parse(_ageFromSearchTextBox.Text);
                ageTo = int.Parse(_ageToSearchTextBox.Text);
            }
            else
            {
                ageFrom = null;
                ageTo = null;
            }
            
            
           var resultSearch = _searchService.SearchUserToProfile(_firstNameSearchTextBox.Text, ageFrom, ageTo, ((LookupValueModel)_cityComboBox.SelectedItem).Id, (Sex)_sexSearchComboBox.SelectedIndex, (Orientations)_orientationSearchComboBox.SelectedIndex);
            ;
            for (int i = 0; i < resultSearch.Count; i++)
            {
                _listBoxAfterSearch.Items.Add(resultSearch[i].FirstName);
            }
            
        }
    }
}
