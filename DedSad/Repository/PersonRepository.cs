using DedSad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DedSad.Repository
{
    internal class PersonRepository
    {
        public async Task<List<Person>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Person>>(ServerConstants.Host + "v1/people");
            return list;
        }

        public async Task<Person> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Person>(ServerConstants.Host + "v1/people/" + id);
            return item;
        }

        public async Task<Person> Update(Person person)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Person>(ServerConstants.Host + "v1/people", person);
            return await item.Content.ReadFromJsonAsync<Person>();
        }

        public async Task<Person> Create(Person person)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Person>(ServerConstants.Host + "v1/people", person);
            return await item.Content.ReadFromJsonAsync<Person>();
        }

        public async Task<Person> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Person>(ServerConstants.Host + "v1/people/" + id);
            return item;
        }
    }
}
