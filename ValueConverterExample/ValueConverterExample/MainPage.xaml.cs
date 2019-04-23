using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ValueConverterExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public class MainPageModel
        {
            public string NotNullString { get; set; } = "I'm not null!";
            public string NullString { get; set; } = null;
        }

        MainPageModel Model = new MainPageModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = Model;
        }
    }
}
