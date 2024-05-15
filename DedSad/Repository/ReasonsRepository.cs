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
    internal class ReasonsRepository
    {
        public async Task<List<Reasons>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Reasons>>(ServerConstants.Host + "v1/reasons");
            return list;
        }

        public async Task<Reasons> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Reasons>(ServerConstants.Host + "v1/reasons/" + id);
            return item;
        }

        public async Task<Reasons> Update(Reasons reasons)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Reasons>(ServerConstants.Host + "v1/reasons", reasons);
            return await item.Content.ReadFromJsonAsync<Reasons>();
        }

        public async Task<Reasons> Create(Reasons reasons)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Reasons>(ServerConstants.Host + "v1/reasons", reasons);
            return await item.Content.ReadFromJsonAsync<Reasons>();
        }

        public async Task<Reasons> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Reasons>(ServerConstants.Host + "v1/reasons/" + id);
            return item;
        }
    }
}
