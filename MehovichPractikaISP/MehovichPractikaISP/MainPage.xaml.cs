using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MehovichPractikaISP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Начало работы
            //Проверка работы с коммитами
            InitializeComponent();
        }

        private void Exit_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
