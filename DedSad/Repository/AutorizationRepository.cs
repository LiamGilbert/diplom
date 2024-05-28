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
        public async Task<List<Authorization>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Authorization>>(ServerConstants.Host + "v1/authorization");
            return list;
        }

        public async Task<Authorization> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Authorization>(ServerConstants.Host + "v1/authorization/" + id);
            return item;
        }

        public async Task<Authorization> Update(Authorization autorization)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Authorization>(ServerConstants.Host + "v1/authorization", autorization);
            return await item.Content.ReadFromJsonAsync<Authorization>();
        }

        public async Task<Authorization> Create(Authorization autorization)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Authorization>(ServerConstants.Host + "v1/authorization", autorization);
            return await item.Content.ReadFromJsonAsync<Authorization>();
        }

        public async Task<Authorization> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Authorization>(ServerConstants.Host + "v1/authorization/" + id);
            return item;
        }

        public async Task<Authorization> Login(Authorization autorization)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Authorization>(ServerConstants.Host + "v1/authorization/login", autorization);
            if(item.IsSuccessStatusCode == false)
            {
                throw new Exception();
            }
            return await item.Content.ReadFromJsonAsync<Authorization>();
        }
    }
}
