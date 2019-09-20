*Change XXXX to the name of your project*

using XXXX;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ButtonDemos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XXXX: ContentPage
    {
        public XXXX()
        {
            InitializeComponent();
        }

        async void PopEvento_25(object sender, System.EventArgs e)
        {
            var page = new PopEvento_25();

            await PopupNavigation.Instance.PushAsync(page);
        }


        async void PopEvento_26(object sender, System.EventArgs e)
        {
            var page = new PopEvento_26();

            await PopupNavigation.Instance.PushAsync(page);
        }


        async void Dia_Livre(object sender, System.EventArgs e)
        {
            var page = new PopEvento_Livre();

            await PopupNavigation.Instance.PushAsync(page);
        }

    }
}
