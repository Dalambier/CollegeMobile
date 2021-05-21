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
    public partial class ProfessionsList : ContentPage
    {
        public ProfessionsList()
        {
            InitializeComponent();
        }

        private void ISIP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Professions.ISIP());
        }

        private void MCI_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Professions.MCI());
        }
    }
}