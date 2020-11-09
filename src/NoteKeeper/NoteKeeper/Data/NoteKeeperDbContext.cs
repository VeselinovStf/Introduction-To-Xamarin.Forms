using NoteKeeper.Models;
using System.Collections.Generic;

namespace NoteKeeper.Data
{
    public class NoteKeeperDbContext
    {
        public IList<NoteType> NoteTypes { get; set; } = new List<NoteType>()
        {
            new NoteType(){ Id = 1, Name = "School Note"},
            new NoteType(){ Id = 1, Name = "Work Note"},
            new NoteType(){ Id = 1, Name = "FreeTime Note"},
        };
    }
}