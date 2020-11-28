using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Ticket : BaseEntity
    {
        public override string ToString()
        {
            return TicketGenre.ToString();
        }

        public TicketSalesType TicketSalesType { get; set; } //internetten mi yoksa gişeden mi olduğunu belirtiyor.
        public Employee SaleOfEmp { get; set; }
        public decimal TicketPrice { get; set; }
        public TicketGenre TicketGenre { get; set; } //öğrenci,vip vs bileti.
        public DateTime? TicketDay { get; set; }
        public Movie MovieName { get; set; }
        public MovieSeans MovieSeans { get; set; }
        public Salon MovieSalon { get; set; }
        public Seat SelectedSeat { get; set; }
        public int AppUserID { get; set; }
        public int MovieID { get; set; }

        public Ticket()
        {
            TicketDay = DateTime.Now;
        }

        public void TicketComplete()
        {
            if (this.MovieName.TicketCount == ' ')
            {
                this.MovieName.TicketCount = 0;
            }
            else
            {
                this.MovieName.TicketCount++;
            }
            this.CreatedBy = this.SaleOfEmp.EmpFirstName + this.SaleOfEmp.EmpLastName;
        }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual Movie Movie { get; set; }

    }
}
