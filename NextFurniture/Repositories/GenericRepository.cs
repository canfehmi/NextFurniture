using Microsoft.EntityFrameworkCore;
using NextFurniture.Models.DAL.Context;
using NextFurniture.Models.DAL.Entities;
using System.Linq.Expressions;

namespace NextFurniture.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        NextFurnitureContext db = new NextFurnitureContext();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd(T item)
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
        public void TRemove(T item)
        {
            db.Set<T>().Remove(item);
            db.SaveChanges();
        }
        public void TUpdate(T item)
        {
            db.SaveChanges();
        }
        public void TGet(int id)
        {
            db.Set<T>().Find(id);
        }
        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}
