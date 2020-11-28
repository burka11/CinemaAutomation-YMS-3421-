using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class MovieGenreMap:BaseMap<MovieGenre>
    {
        public MovieGenreMap()
        {
           
            Property(x => x.GenreName).HasMaxLength(20).IsRequired();
            
        }
    }
}
