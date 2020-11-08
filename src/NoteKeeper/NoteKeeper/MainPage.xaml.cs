using NoteKeeper.Views;

using Xamarin.Forms;

namespace NoteKeeper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void AddNote_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NoteDetailsPage()));
        }     
    }
}
