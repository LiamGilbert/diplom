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
    internal class ParentsRepository
    {
        public async Task<List<Parents>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Parents>>(ServerConstants.host + "v1/parents");
            return list;
        }

        public async Task<Parents> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Parents>(ServerConstants.host + "v1/parents/" + id);
            return item;
        }

        public async Task<Parents> Update(Parents parents)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Parents>(ServerConstants.host + "v1/parents", parents);
            return await item.Content.ReadFromJsonAsync<Parents>();
        }

        public async Task<Parents> Create(Parents parents)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Parents>(ServerConstants.host + "v1/parents", parents);
            return await item.Content.ReadFromJsonAsync<Parents>();
        }

        public async Task<Parents> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Parents>(ServerConstants.host + "v1/parents/" + id);
            return item;
        }
    }
}
