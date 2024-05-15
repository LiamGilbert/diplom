using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSad.Models
{
    public class Group
    {
        public int id_group { get; set; }
        public string group_name { get; set; }
        public int id_type { get; set; }
        public int id_person { get; set; }

        public Person person { get; set; }
        public GroupTypes type { get; set; }
    }
}
