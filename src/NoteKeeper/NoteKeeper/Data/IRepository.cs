using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteKeeper.Data
{
    public interface IRepository<T>
    {
        IList<T> GetAll();
    }
}
