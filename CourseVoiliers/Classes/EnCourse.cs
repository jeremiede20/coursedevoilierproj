using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CourseVoiliers.Classes
{
    public class EnCourse
    {

        public int id_Voilier { get; set; }
        public int id_Course { get; set; }
        public string tempsBrut { get; set; }
        public string tempsReel { get; set; }

    }
}