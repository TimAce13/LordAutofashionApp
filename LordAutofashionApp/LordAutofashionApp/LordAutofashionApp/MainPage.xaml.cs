using LordAutofashionApp.ViewModels;
using Xamarin.Forms;

namespace LordAutofashionApp
{
    public partial class MainPage : ContentPage
    {
        private BrigadePlansViewModel _brigadePlansViewModel;
        public MainPage()
        {
            InitializeComponent();
            
            BindingContext = new BrigadePlansViewModel();

        }

        private void CheckBoxChanged(object sender, CheckedChangedEventArgs checkedChangedEventArgs)
        {
           // SendToServer("3BUGTEST3");
           // There I send info to Logs, deleted for now
        }
    }
}