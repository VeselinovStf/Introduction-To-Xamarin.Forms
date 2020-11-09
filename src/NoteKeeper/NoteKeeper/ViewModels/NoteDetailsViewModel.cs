using NoteKeeper.Data;
using NoteKeeper.Models;
using NoteKeeper.Services;
using System.Collections.Generic;
using System.Linq;

namespace NoteKeeper.ViewModels
{
    public class NoteDetailsViewModel : BaseViewModel
    {
        private readonly NoteTypeService NoteTypeService;
        
        public List<NoteType> NoteTypes { get; private set; }
        private Note Note { get; }

        public NoteDetailsViewModel(Note note = null)
        {
            NoteTypeService = new NoteTypeService(new NoteTypeRepository(new NoteKeeperDbContext()));

            NoteTypes = new List<NoteType>();

            if (note != null)
            {
                Note = note;
            }
            else
            {
                Note = new Note() { Text = "", Title = "" };
            }
            

            Load();
        }

        

        public string NoteTitle
        {
            get 
            { 
                return Note.Title; }
            set 
            {
                Note.Title = value;
                OnPropertyChanged();
            }
        }


        public string NoteText
        {
            get 
            { 
                return Note.Text; 
            }
            set
            {
                Note.Text = value;
                OnPropertyChanged();
            }
        }



        public  void Load()
        {
            var noteTypes =  this.NoteTypeService.GetAllNoteTypes();

            this.NoteTypes = noteTypes.ToList();
        }


    }
}
