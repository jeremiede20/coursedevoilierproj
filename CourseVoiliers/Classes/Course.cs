using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseVoiliers.Classes
{
    public class Course
    {
        [Key]
        public int id { get; set; }
        public DateTime dateDepart { get; set; }
        public DateTime dateArrivee { get; set; }
        public string lieuDepart { get; set; }
        public string lieuArrivee { get; set; }

    }
}
