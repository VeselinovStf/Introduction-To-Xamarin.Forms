using NoteKeeper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Data
{
    //In-Memory Db
    public class NoteTypeRepository : IRepository<NoteType>
    {
        private readonly NoteKeeperDbContext _dbContext;

        public NoteTypeRepository(NoteKeeperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(NoteType newNoteType)
        {
            _dbContext.NoteTypes.Add(newNoteType);
        }

        public IList<NoteType> GetAll()
        {          
                return this._dbContext.NoteTypes;            
        }
    }
}
