using NoteKeeper.Data;
using NoteKeeper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public class NoteTypeService : INoteTypeService
    {
        private readonly NoteTypeRepository _noteTypeRepository;

        public NoteTypeService(IRepository<NoteType> noteTypeRepository)
        {
            _noteTypeRepository = (NoteTypeRepository)noteTypeRepository;
        }

        public IList<NoteType> GetAllNoteTypes()
        {
            return  this._noteTypeRepository.GetAll();
        }
    }
}
