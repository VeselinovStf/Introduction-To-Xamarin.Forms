using NoteKeeper.Data;
using NoteKeeper.Models;
using NoteKeeper.Services;
using NoteKeeper.Views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoteKeeper.ViewModels
{
    public class NoteListViewModel : BaseViewModel
    {
        public NoteListViewModel()
        {
            NoteService = new NoteService(new NoteRepository(new NoteKeeperDbContext()));

            NotesList = new ObservableCollection<Note>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NoteDetailsPage, NoteDetailsViewModel>(this, "SaveNote", (sender, noteViewModel) =>
             {
                 var newNote = new Note() { Text = noteViewModel.NoteText, Title = noteViewModel.NoteTitle };
                 NotesList.Add(newNote);
                 NoteService.AddNote(newNote);
             });
        }

        private async Task ExecuteLoadItemsCommand()
        {
            this.NotesList.Clear();

            var notes = this.NoteService.GetAllNotes();

            foreach (var note in notes)
            {
                NotesList.Add(note);
            }

            await Task.Delay(1);
        }

        public INoteService NoteService { get; }
        public ObservableCollection<Note> NotesList { get; }
        public Command LoadItemsCommand { get; }
    }
}
