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
    internal class AddressRepository
    {
        public async Task<List<Address>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Address>>(ServerConstants.Host + "v1/address");
            return list;
        }

        public async Task<Address> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Address>(ServerConstants.Host + "v1/address/" + id);
            return item;
        }

        public async Task<Address> Update(Address address)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Address>(ServerConstants.Host + "v1/address", address);
            return await item.Content.ReadFromJsonAsync<Address>();
        }

        public async Task<Address> Create(Address address)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Address>(ServerConstants.Host + "v1/address", address);
            return await item.Content.ReadFromJsonAsync<Address>();
        }

        public async Task<Address> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Address>(ServerConstants.Host + "v1/address/" + id);
            return item;
        }
    }
}
