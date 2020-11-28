using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class AppUserProfile : BaseEntity
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public Gender Gender { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
    }
}
