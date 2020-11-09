using NoteKeeper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Data
{
    //In-Memory Db
    public class NoteTypeRepository : IAsyncRepository<NoteType>
    {
        private readonly NoteKeeperDbContext _dbContext;

        public NoteTypeRepository(NoteKeeperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<NoteType>> GetAllAsync()
        {
            return await Task.Run(() => 
            {
                return this._dbContext.NoteTypes;
            });
        }
    }
}
