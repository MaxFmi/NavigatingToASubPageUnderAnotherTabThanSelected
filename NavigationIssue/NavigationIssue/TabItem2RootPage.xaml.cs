using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationIssue
{
    public partial class TabItem2RootPage : ContentPage
    {
        public TabItem2RootPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            // A separate navigation call to select the target tab.
            // await Shell.Current.GoToAsync("//TabBar/Tab.Item3/");
            
            // When we only have this invocation, the target tab will not be selected.  
            await Shell.Current.GoToAsync("//TabBar/Tab.Item3/" + nameof(ModalPage));
        }
    }
}