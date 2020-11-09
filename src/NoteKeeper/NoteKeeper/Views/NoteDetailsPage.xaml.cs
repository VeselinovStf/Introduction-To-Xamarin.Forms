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
        }

        private void CancelNote_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Saving Canceled", "You Cancel Note Save", "Ok","Cancel");
        }

        private void SaveNote_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Saving", "You Want to save new note", "Ok", "Cancel");

        }
    }
}