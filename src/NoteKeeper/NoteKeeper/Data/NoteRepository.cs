using NoteKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteKeeper.Data
{
    public class NoteRepository : IRepository<Note>
    {
        private readonly NoteKeeperDbContext _dbContext;

        public NoteRepository(NoteKeeperDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IList<Note> GetAll()
        {
            return this._dbContext.Notes;
        }

        public void Add(Note newNote)
        {
            _dbContext.Notes.Add(newNote);
        }
    }
}
