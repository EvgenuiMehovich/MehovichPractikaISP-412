using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MehovichPractikaISP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registr : ContentPage
    {
        public Registr()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}