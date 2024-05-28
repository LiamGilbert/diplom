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
    internal class ChildrensRepository
    {
        public async Task<List<Children>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Children>>(ServerConstants.Host + "v1/childrens");
            return list;
        }

        public async Task<Children> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Children>(ServerConstants.Host + "v1/childrens/" + id);
            return item;
        }

        public async Task<Children> Update(Children childrens)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Children>(ServerConstants.Host + "v1/childrens", childrens);
            return await item.Content.ReadFromJsonAsync<Children>();
        }

        public async Task<Children> Create(Children childrens)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Children>(ServerConstants.Host + "v1/childrens", childrens);
            return await item.Content.ReadFromJsonAsync<Children>();
        }

        public async Task<Children> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Children>(ServerConstants.Host + "v1/childrens/" + id);
            return item;
        }
    }
}
