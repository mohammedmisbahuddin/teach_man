using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Teach_man.Services
{
    public interface SDataStore<T>
    {
        Task<T> GetScienceItemAsync(string id);
        Task<IEnumerable<T>> GetScienceItemAsync(bool forceRefresh = false);
    }
}
