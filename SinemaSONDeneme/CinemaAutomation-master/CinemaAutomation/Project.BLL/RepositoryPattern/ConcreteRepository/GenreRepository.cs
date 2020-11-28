using Project.BLL.RepositoryPattern.BaseRepository;
using Project.BLL.SingletonPattern;
using Project.DAL.Context;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.RepositoryPattern.ConcreteRepository
{
   public class MovieGenreRepository:BaseRepository<MovieGenre>
    {
        MyContext db;
        public MovieGenreRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Update(MovieGenre item)
        {
            item.Status = DataStatus.Updated;

            item.ModifiedDate = DateTime.Now;
            MovieGenre toBeUpdated = GetByID(item.ID);

            db.Entry(toBeUpdated).CurrentValues.SetValues(item);
            Save();
        }
    }
}
