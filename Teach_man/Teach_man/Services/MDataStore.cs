using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Teach_man.Services
{
    public interface MDataStore<T>
    {
        Task<T> GetMathsItemAsync(string id);
        Task<IEnumerable<T>> GetMathsItemAsync(bool forceRefresh = false);
    }
}