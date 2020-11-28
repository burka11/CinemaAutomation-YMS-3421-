using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Salon : BaseEntity
    {
        public override string ToString()
        {
            return SalonNumber.ToString();
        }

        public ushort SalonNumber { get; set; }

        [Required]
        [Range(1, 300)]
        public short Capacity { get; set; }

        public int MovieID { get; set; }

        //Relaitonal Properties

        public virtual Movie Movie { get; set; }

        public virtual List<Seat> Seats { get; set; }
    }
}
