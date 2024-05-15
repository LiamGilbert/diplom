using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSad.Models
{
    public class Parents
    {
        public int id_parent { get; set; }
        public string mother { get; set; }
        public string father { get; set; }
        public int id_child { get; set; }
        public Person children { get; set; }
    }
}
