using BruteForceGui.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyBruteForceAll
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel _vm;
        public MainPage()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            BindingContext = _vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _vm.StartBruteForceAsync();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            _vm.Reset();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            _vm.ProgressStoped();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            _vm.ProgressContinue();
        }

        private void SwitchCellUpper_OnChanged(object sender, ToggledEventArgs e)
        {
            _vm.UpperCase();
        }

        private void SwitchCellLower_OnChanged(object sender, ToggledEventArgs e)
        {
            _vm.LowerCase(); 
        }

        private void SwitchCellNumber_OnChanged(object sender, ToggledEventArgs e)
        {
            _vm.NumberCase(); 
        }

        private void SwitchCellSpecial_OnChanged(object sender, ToggledEventArgs e)
        {
            _vm.SpecialCase();
        }
    }
}
