using NoteKeeper.Data;
using NoteKeeper.Models;
using NoteKeeper.Services;
using System.Collections.Generic;
using System.Linq;

namespace NoteKeeper.ViewModels
{
    public class NoteDetailsViewModel
    {
        private readonly NoteTypeService NoteTypeService;

        public List<NoteType> NoteTypes { get; private set; }

        public NoteDetailsViewModel()
        {
            NoteTypeService = new NoteTypeService(new NoteTypeRepository(new NoteKeeperDbContext()));

            NoteTypes = new List<NoteType>();

            Load();
        }

        private Note _selectedNote;

        public Note SelectedNote
        {
            get 
            {
                if (_selectedNote == null)
                {
                    return new Note()
                    {
                        Text = "",
                        Title = "",
                        NoteType = new NoteType() { Name = "ASd"}
                    };
                }

                return _selectedNote; 
            }
            set 
            { 
                _selectedNote = value;
            }
        }


        public  void Load()
        {
            var noteTypes =  this.NoteTypeService.GetAllNoteTypes();

            this.NoteTypes = noteTypes.ToList();
        }


    }
}
