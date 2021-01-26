using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class Trainer
    {
        [Key]
        public int TrainerID { get; set; } // this is primary key
        public string Trainername { get; set; } // this is trainer name
        public string Phone { get; set; } // this is phone number
        public string Address { get; set; } // this is address
        public string Sex{ get; set; } // this is sex
        public string CostPerHour { get; set; } // this is cost per hour
    }
}
