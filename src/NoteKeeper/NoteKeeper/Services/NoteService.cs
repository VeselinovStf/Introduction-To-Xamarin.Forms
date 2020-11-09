using NoteKeeper.Data;
using NoteKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteKeeper.Services
{
    public class NoteService : INoteService
    {
        private readonly NoteRepository _noteRepository;

        public NoteService(
            IRepository<Note> noteRepository)
        {
            _noteRepository = (NoteRepository)noteRepository;
        }

        public IList<Note> GetAllNotes()
        {
            return this._noteRepository.GetAll();
        }

        public void AddNote(Note newNote)
        {
            _noteRepository.Add(newNote);
        }
    }
}
