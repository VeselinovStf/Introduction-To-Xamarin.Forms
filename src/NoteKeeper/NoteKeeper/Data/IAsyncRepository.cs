using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Data
{
    public interface IAsyncRepository<T>
    {
        Task<IList<T>> GetAllAsync();
    }
}
