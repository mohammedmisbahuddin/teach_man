using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teach_man.Models;

namespace Teach_man.Services
{
    public class Science_MockDataStore : SDataStore<ScienceItems>
    {
        List<ScienceItems> ScienceItemss;

        public Science_MockDataStore()
        {
            ScienceItemss = new List<ScienceItems>();



            var mockScienceItemss = new List<ScienceItems>
            {
                new ScienceItems { Id = Guid.NewGuid().ToString(), Text = "First ScienceItems", Description="This is an ScienceItems description." },
                new ScienceItems { Id = Guid.NewGuid().ToString(), Text = "Second ScienceItems", Description="This is an ScienceItems description." },
                new ScienceItems { Id = Guid.NewGuid().ToString(), Text = "Third ScienceItems", Description="This is an ScienceItems description." },
                new ScienceItems { Id = Guid.NewGuid().ToString(), Text = "Fourth ScienceItems", Description="This is an ScienceItems description." },
                new ScienceItems { Id = Guid.NewGuid().ToString(), Text = "Fifth ScienceItems", Description="This is an ScienceItems description." },
                new ScienceItems { Id = Guid.NewGuid().ToString(), Text = "Sixth ScienceItems", Description="This is an ScienceItems description." },
            };

            foreach (var ScienceItems in mockScienceItemss)
            {
                ScienceItemss.Add(ScienceItems);
            }


        }
        public async Task<ScienceItems> GetScienceItemAsync(string id)
        {
            return await Task.FromResult(ScienceItemss.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ScienceItems>> GetScienceItemAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(ScienceItemss);
        }

    }

}