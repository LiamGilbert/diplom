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
    internal class AttendanceRepository
    {
        public async Task<List<Attendance>> GetAllAsync()
        {
            HttpClient client = new HttpClient();
            var list = await client.GetFromJsonAsync<List<Attendance>>(ServerConstants.host + "v1/attendance");
            return list;
        }

        public async Task<Attendance> GetById(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.GetFromJsonAsync<Attendance>(ServerConstants.host + "v1/attendance/" + id);
            return item;
        }

        public async Task<Attendance> Update(Attendance attendance)
        {
            HttpClient client = new HttpClient();
            var item = await client.PutAsJsonAsync<Attendance>(ServerConstants.host + "v1/attendance", attendance);
            return await item.Content.ReadFromJsonAsync<Attendance>();
        }

        public async Task<Attendance> Create(Attendance attendance)
        {
            HttpClient client = new HttpClient();
            var item = await client.PostAsJsonAsync<Attendance>(ServerConstants.host + "v1/attendance", attendance);
            return await item.Content.ReadFromJsonAsync<Attendance>();
        }

        public async Task<Attendance> Delete(int id)
        {
            HttpClient client = new HttpClient();
            var item = await client.DeleteFromJsonAsync<Attendance>(ServerConstants.host + "v1/attendance/" + id);
            return item;
        }
    }
}
