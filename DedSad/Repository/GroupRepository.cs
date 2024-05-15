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
    internal class GroupRepository
    {
        public async Task<List<Group>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Group>>(ServerConstants.Host + "v1/groups");
            return list;
        }

        public async Task<Group> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Group>(ServerConstants.Host + "v1/groups/" + id);
            return item;
        }

        public async Task<Group> Update(Group group)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Group>(ServerConstants.Host + "v1/groups", group);
            return await item.Content.ReadFromJsonAsync<Group>();
        }

        public async Task<Group> Create(Group group)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Group>(ServerConstants.Host + "v1/groups", group);
            return await item.Content.ReadFromJsonAsync<Group>();
        }

        public async Task<Group> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Group>(ServerConstants.Host + "v1/groups/" + id);
            return item;
        }
    }
}
