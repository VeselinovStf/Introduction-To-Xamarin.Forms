using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using NoteKeeper.Views;

using Xamarin.Forms;

namespace NoteKeeper
{
    public partial class MainPage : ContentPage
    {
        public NoteListViewModel ViewModel { get; }
   
        public MainPage()
        {
            InitializeComponent();

            ViewModel = new NoteListViewModel();

            BindingContext = ViewModel;
        }

        async void NoteDetailsPage_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NoteDetailsPage(new NoteDetailsViewModel())));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel.NotesList.Count == 0)
            {
                ViewModel.LoadItemsCommand.Execute(null);
            }
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var note = e.SelectedItem as Note;

            if (note == null)
            {
                return;
            }

            await Navigation.PushModalAsync(new NavigationPage(new NoteDetailsPage(new NoteDetailsViewModel(note))));

            ItemsListView.SelectedItem = null;
        }
    }
}
