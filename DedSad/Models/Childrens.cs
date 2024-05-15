using System.Text.Json.Serialization;

namespace DedSad.Models
{
    public class Childrens
    {
        public int id_children { get; set; }
        public int id_person { get; set; }
        public int id_group { get; set; }

        public Person person { get; set; }
        public Group group { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string female { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string man { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string sex_name => person != null && person.sex ? "М" : "Ж";
    }
}
