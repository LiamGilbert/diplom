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
        public async Task<List<Childrens>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Childrens>>(ServerConstants.host + "v1/childrens");
            return list;
        }

        public async Task<Childrens> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Childrens>(ServerConstants.host + "v1/childrens/" + id);
            return item;
        }

        public async Task<Childrens> Update(Childrens childrens)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Childrens>(ServerConstants.host + "v1/childrens", childrens);
            return await item.Content.ReadFromJsonAsync<Childrens>();
        }

        public async Task<Childrens> Create(Childrens childrens)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Childrens>(ServerConstants.host + "v1/childrens", childrens);
            return await item.Content.ReadFromJsonAsync<Childrens>();
        }

        public async Task<Childrens> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Childrens>(ServerConstants.host + "v1/childrens/" + id);
            return item;
        }
    }
}
