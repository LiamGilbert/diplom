using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DedSad.Models
{
    public class Person
    {
        public int id_person { get; set; }
        public string lastname { get; set; } = String.Empty;
        public string firstname { get; set; } = String.Empty;
        public string patronymic { get; set; } = String.Empty;
        public bool sex { get; set; }
        public int id_address { get; set; }
        public int id_role { get; set; }
        public Role role { get; set; }
        public Address address { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string FullName => $"{lastname} {firstname} {patronymic}";
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string sex_name => sex ? "М" : "Ж";
    }
}
