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
    internal class RoleRepository
    {
        public async Task<List<Role>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Role>>(ServerConstants.Host + "v1/roles");
            return list;
        }

        public async Task<Role> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Role>(ServerConstants.Host + "v1/roles/" + id);
            return item;
        }

        public async Task<Role> Update(Role role)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Role>(ServerConstants.Host + "v1/roles", role);
            return await item.Content.ReadFromJsonAsync<Role>();
        }

        public async Task<Role> Create(Role role)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Role>(ServerConstants.Host + "v1/roles", role);
            return await item.Content.ReadFromJsonAsync<Role>();
        }

        public async Task<Role> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Role>(ServerConstants.Host + "v1/roles/" + id);
            return item;
        }
    }
}
