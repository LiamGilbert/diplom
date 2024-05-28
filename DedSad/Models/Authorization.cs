using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSad.Models
{
    public class Authorization
    {
        public int id_autorization { get; set; }
        public string login { get; set; } = String.Empty;
        public string password { get; set; } = String.Empty;
        public int id_person { get; set; }
        public Person person { get; set; }
    }
}
