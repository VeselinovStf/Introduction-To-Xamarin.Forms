using NoteKeeper.Models;
using System.Collections.Generic;

namespace NoteKeeper.Services
{
    public interface INoteService
    {
        IList<Note> GetAllNotes();
        void AddNote(Note newNote);

    }
}