using NoteKeeper.Data;
using NoteKeeper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public class NoteTypeService : INoteTypeService
    {
        private readonly NoteTypeRepository _noteTypeRepository;

        public NoteTypeService(IAsyncRepository<NoteType> noteTypeRepository)
        {
            _noteTypeRepository = (NoteTypeRepository)noteTypeRepository;
        }

        public async Task<IList<NoteType>> GetAllNoteTypesAsync()
        {
            return await this._noteTypeRepository.GetAllAsync();
        }
    }
}
