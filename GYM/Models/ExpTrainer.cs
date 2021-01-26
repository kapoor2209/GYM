using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class ExpTrainer
    {
        [Key]
       public int ID { get; set; }
        public int TrainerID { get; set; } // this is foreign key
        public Trainer Trainer { get; set; } // this is foreign key

        public int ExersiceID { get; set; } // this is foreign key
        public Exersice Exersice { get; set; } // this is foreign key

    }
}
