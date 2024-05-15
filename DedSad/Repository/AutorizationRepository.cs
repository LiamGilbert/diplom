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
    internal class AutorizationRepository
    {
        public async Task<List<Autorization>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Autorization>>(ServerConstants.Host + "v1/authorization");
            return list;
        }

        public async Task<Autorization> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Autorization>(ServerConstants.Host + "v1/authorization/" + id);
            return item;
        }

        public async Task<Autorization> Update(Autorization autorization)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Autorization>(ServerConstants.Host + "v1/authorization", autorization);
            return await item.Content.ReadFromJsonAsync<Autorization>();
        }

        public async Task<Autorization> Create(Autorization autorization)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Autorization>(ServerConstants.Host + "v1/authorization", autorization);
            return await item.Content.ReadFromJsonAsync<Autorization>();
        }

        public async Task<Autorization> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Autorization>(ServerConstants.Host + "v1/authorization/" + id);
            return item;
        }

        public async Task<Autorization> Login(Autorization autorization)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Autorization>(ServerConstants.Host + "v1/authorization/login", autorization);
            if(item.IsSuccessStatusCode == false)
            {
                throw new Exception();
            }
            return await item.Content.ReadFromJsonAsync<Autorization>();
        }
    }
}
