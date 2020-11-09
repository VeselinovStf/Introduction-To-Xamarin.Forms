using NoteKeeper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public interface INoteTypeService
    {
        Task<IList<NoteType>> GetAllNoteTypesAsync();
    }
}