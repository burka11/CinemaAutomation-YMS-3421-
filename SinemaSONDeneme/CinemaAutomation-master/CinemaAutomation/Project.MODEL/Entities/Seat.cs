using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Seat : BaseEntity
    {
        [Required] 
        public string SeatNumber { get; set; } // Hangi Numara olduğu => G-1 ,F-3 .. 

        public bool IsEmpty { get; set; }

        public int SalonID { get; set; }

        public Seat()
        {
            IsEmpty = true;
        }
        //Relational Properties
        public virtual Salon Salon { get; set; }

    }
}
