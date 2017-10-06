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
    }
}
