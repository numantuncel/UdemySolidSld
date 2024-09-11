using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemySolid.Data;

namespace UdemySolid.Business
{
    public class _BaseBusiness<TEntity> where TEntity : class
    {
        private _BaseRepository<TEntity> _repository;

        public _BaseBusiness()
        {
            _repository = new _BaseRepository<TEntity>();
        }
        public void Add(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _repository.Delete(entity);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return _repository.GetById(id);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public List<TEntity> GetAll()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
