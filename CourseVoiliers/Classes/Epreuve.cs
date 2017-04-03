using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourseVoiliers.Classes
{
    public class Epreuve
    {

        [Key]
        public int id { get; set; }
        public string nom { get; set; }
        public string lieuDepart { get; set; }
        public string lieuArrivee { get; set; }
        public DateTime dateDepart { get; set; }
        public DateTime dateArrivee { get; set; }

    }
}