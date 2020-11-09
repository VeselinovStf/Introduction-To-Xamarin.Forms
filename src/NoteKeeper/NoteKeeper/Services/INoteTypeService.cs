using NoteKeeper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Services
{
    public interface INoteTypeService
    {
        IList<NoteType> GetAllNoteTypes();
    }
}