using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeMobile.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Professions_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfessionsList());
        }

        private void Buildings_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new BuildingList());
        }

        private void Info_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new AboutPrigram());
        }
    }
}