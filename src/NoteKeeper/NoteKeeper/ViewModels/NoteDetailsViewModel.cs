using NoteKeeper.Data;
using NoteKeeper.Services;

namespace NoteKeeper.ViewModels
{
    public class NoteDetailsViewModel
    {
        private readonly NoteTypeService NoteTypeService;
        public NoteDetailsViewModel()
        {
            NoteTypeService = new NoteTypeService(new NoteTypeRepository(new NoteKeeperDbContext()));
        }
    }
}
