using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DedSad.Models
{
    public class Address
    {
        public int id_address { get; set; }
        public string town { get; set; } = String.Empty;
        public string street { get; set; } = String.Empty;
        public string house_number { get; set; } = String.Empty;

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string FullName => $"{town}, {street}, {house_number}";
    }
}
