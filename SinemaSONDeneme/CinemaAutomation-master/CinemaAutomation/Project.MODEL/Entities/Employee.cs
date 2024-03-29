﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Employee : BaseEntity
    {
        public override string ToString()
        {
            return $"{EmpFirstName} {EmpLastName} , ID= {ID} , Rütbesi: {Title}";
        }

        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpUserName { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Title { get; set; }  //buradan alttaki sınıra kadar boş geçilecek. ((adress dahil)
        public string TitleOfCourtesy { get; set; }
        public string Extensions { get; set; }
        public string Photo { get; set; } //todo MAP katmanında null geçilebilir olması sağlanacak.
        public string PhotoPath { get; set; } //todo MAP katmanında null geçilebilir olması sağlanacak.
        public int? ReportsTo { get; set; }
        public string Address { get; set; }

    }
}
