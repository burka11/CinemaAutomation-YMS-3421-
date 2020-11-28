using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class MovieGenre : BaseEntity
    {
        public override string ToString()
        {
            return GenreName;
        }
        public string GenreName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        public virtual List<Movie> Movies { get; set; }


    }
}
