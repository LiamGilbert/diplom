using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedSad.Models
{
    public class Attendance
    {
        public int id_attendance { get; set; }
        public int id_child { get; set; }
        public DateTime date { get; set; }
        public string mark { get; set; } = String.Empty;
        public int? id_reason { get; set; }

        public Childrens children { get; set; }

        public Reasons reason { get; set; }
    }
}
