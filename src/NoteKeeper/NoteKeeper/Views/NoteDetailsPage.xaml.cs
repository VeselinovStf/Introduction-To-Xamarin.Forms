using NoteKeeper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoteKeeper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteDetailsPage : ContentPage
    {
        public NoteDetailsViewModel ViewModel { get; }

        public NoteDetailsPage(NoteDetailsViewModel viewModel)
        {
            InitializeComponent();

            ViewModel = viewModel;

            BindingContext = this.ViewModel;

            Title = ViewModel.Title;
        }

        private async void CancelNote_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void SaveNote_Clicked(object sender, System.EventArgs e)
        {
            MessagingCenter.Send(this, "SaveNote", ViewModel);


            await Navigation.PopModalAsync();

        }
    }
}