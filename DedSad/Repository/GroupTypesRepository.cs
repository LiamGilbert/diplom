using DedSad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DedSad.Repository
{
    internal class GroupTypesRepository
    {
        public async Task<List<GroupTypes>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<GroupTypes>>(ServerConstants.Host + "v1/grouptypes");
            return list;
        }

        public async Task<GroupTypes> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<GroupTypes>(ServerConstants.Host + "v1/grouptypes/" + id);
            return item;
        }

        public async Task<GroupTypes> Update(GroupTypes grouptypes)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<GroupTypes>(ServerConstants.Host + "v1/grouptypes", grouptypes);
            return await item.Content.ReadFromJsonAsync<GroupTypes>();
        }

        public async Task<GroupTypes> Create(GroupTypes grouptypes)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<GroupTypes>(ServerConstants.Host + "v1/grouptypes", grouptypes);
            return await item.Content.ReadFromJsonAsync<GroupTypes>();
        }

        public async Task<GroupTypes> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<GroupTypes>(ServerConstants.Host + "v1/grouptypes/" + id);
            return item;
        }
    }
}
