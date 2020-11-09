using NoteKeeper.Data;
using NoteKeeper.Models;
using NoteKeeper.Services;
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

        public NoteService NoteService { get; }
        public ObservableCollection<Note> NotesList { get; }
        public Command LoadItemsCommand { get; }
    }
}
