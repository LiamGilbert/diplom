using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSad.Models
{
    public class Childrens
    {
        public int id_children { get; set; }
        public int id_person { get; set; }
        public int id_group { get; set; }

        public Person person { get; set; }
        public Group group { get; set; }
        public Parents parent {  get; set; }
    }
}
