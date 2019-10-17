using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void CmdlistView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListView());
        }

        private void CmdlistViewGroup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListViewGroup());
        }
    }
}
