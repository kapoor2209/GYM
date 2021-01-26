using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class Exersice
    {
        [Key]
        public int ExcerciseID { get; set; } // this is primary key
        public string ExersiceName { get; set; } // this is exersice name

        [DataType(DataType.Time)]
        public DateTime TimeDuration { get; set; } // this is time duration

        public string Advantage { get; set; } // this is advantage of exersice
        public string Disadvantage { get; set; } // this is disadvantage of exersice
       
    }
}
