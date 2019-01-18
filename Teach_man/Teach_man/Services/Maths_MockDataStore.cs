using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teach_man.Models;

namespace Teach_man.Services
{
    public class Maths_MockDataStore : MDataStore<MathsItems>
    {
        List<MathsItems> MathsItems;

        public Maths_MockDataStore()
        {
            MathsItems = new List<MathsItems>();



            var mockMathsItems = new List<MathsItems>
            {
                new MathsItems { Id = Guid.NewGuid().ToString(), Text = "First MathsItem", Description="This is an MathsItem description." },
                new MathsItems { Id = Guid.NewGuid().ToString(), Text = "Second MathsItem", Description="This is an MathsItem description." },
                new MathsItems { Id = Guid.NewGuid().ToString(), Text = "Third MathsItem", Description="This is an MathsItem description." },
                new MathsItems { Id = Guid.NewGuid().ToString(), Text = "Fourth MathsItem", Description="This is an MathsItem description." },
                new MathsItems { Id = Guid.NewGuid().ToString(), Text = "Fifth MathsItem", Description="This is an MathsItem description." },
                new MathsItems { Id = Guid.NewGuid().ToString(), Text = "Sixth MathsItem", Description="This is an MathsItem description." },
            };

            foreach (var MathsItem in mockMathsItems)
            {
                MathsItems.Add(MathsItem);
            }


        }
        public async Task<MathsItems> GetMathsItemAsync(string id)
        {
            return await Task.FromResult(MathsItems.FirstOrDefault(s => s.Id == id));
        }


        public async Task<IEnumerable<MathsItems>> GetMathsItemAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(MathsItems);
        }

    }

}