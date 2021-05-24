using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeMobile.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingList : ContentPage
    {
        public BuildingList()
        {
            InitializeComponent();
        }

        private void Click_Build1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Buildings.Build1());
        }

        private void Click_Build2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Buildings.Build2());
        }

        private void Click_Build3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Buildings.Build3());
        }
    }
}