using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace UdemySolid.Data
{
    public class _BaseRepository<TEntity> where TEntity : class
    {
        public UdemyContext _context;

        public void Add(TEntity obj)
        {
            _context = new UdemyContext();
            _context.Set<TEntity>().Add(obj);// TEntity e göre çalışan bir DbSet yani tablo
            _context.SaveChanges();
            _context.Dispose();
        }

        public void Update(TEntity obj)
        {
            _context = new UdemyContext();
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            _context.Dispose();
        }

        public void Delete(TEntity obj)
        {
            _context = new UdemyContext();
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
            _context.Dispose();
        }

        public TEntity GetById(int id)
        {
            _context= new UdemyContext();
            TEntity entity = _context.Set<TEntity>().Find(id);
            _context.Dispose();
            return entity;

        }

        public List<TEntity> GetAll()
        {
            _context= new UdemyContext();
            List<TEntity> entities = _context.Set<TEntity>().ToList();
            _context.Dispose();
            return entities;

        }
    }
}
 // Dispose Edilmez ise ikinci istekde hata verir.
// buradaki set DbSet anlamında yani tablo
// Biz buraya hangi entity nin geleceğini bilmiyoruz bu yüzden de
// bu baseRepository TEntiy lıcak biz göndercez ve bu : class olacak

// base = temel

// dispose metodu dosya ve veri tabanı bağlantılarını kapatmak için kullanılır