using NoteKeeper.Models;
using System.Collections.Generic;

namespace NoteKeeper.Data
{
    public class NoteKeeperDbContext
    {
        public IList<NoteType> NoteTypes { get; set; } = new List<NoteType>()
        {
            new NoteType(){ Id = 1, Name = "School Note"},
            new NoteType(){ Id = 2, Name = "Work Note"},
            new NoteType(){ Id = 3, Name = "FreeTime Note"},
        };

        public IList<Note> Notes { get; set; } = new List<Note>()
        {
            new Note(){ Id = 1, Title = "Go to School", Text = "Go to learn some new things", NoteType = new NoteType(){ Id = 1} },
            new Note(){ Id = 1, Title = "Go to Work", Text = "Go earn some money", NoteType = new NoteType(){ Id = 2} },
            new Note(){ Id = 1, Title = "Meditate", Text = "Concentrate and relax", NoteType = new NoteType(){ Id = 3} },
        };
    }
}