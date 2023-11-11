using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDemo : ContentPage
    {
        public PageDemo()
        {
            InitializeComponent();
        }
        public void PushPage(Object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDemo());
        }
        public void PopPage(Object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        public void PushModalPage(Object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PageDemo());
        }
        public void PopModalPage(Object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

    }
}