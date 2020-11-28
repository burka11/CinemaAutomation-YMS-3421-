using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Seans : BaseEntity
    {
        public override string ToString()
        {
            return SeansTime;
        }

        public string SeansTime { get; set; }  //Saat ve ay olarak nasıl ayırıcaz?

        //Relational Properties

        public virtual List<MovieSeans> MovieSeanss { get; set; }

    }
}
