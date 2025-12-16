using Os.Domain.Base;
using Os.Repository.Context;
using Microsoft.EntityFrameworkCore;


namespace Os.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected OsContext _mysSqlContext;

        public BaseRepository(OsContext mySqlContext)
        {
            _mysSqlContext = mySqlContext;
        }

        public void AttachObject(object obj)
        {
            _mysSqlContext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mysSqlContext.ChangeTracker.Clear();
        }

        public void Insert(TEntity obj)
        {
            _mysSqlContext.Set<TEntity>().Add(obj);
            _mysSqlContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _mysSqlContext.ChangeTracker.Clear();

            
            var existingObj = _mysSqlContext.Set<TEntity>().Find(obj.Id);

            if (existingObj != null)
            {
                
                var entry = _mysSqlContext.Entry(existingObj);

                
                entry.CurrentValues.SetValues(obj);

               
                entry.Property("Id").IsModified = false;

                
                _mysSqlContext.SaveChanges();
            }
            else
            {
                throw new Exception("Erro: Registro não encontrado no banco de dados para atualização.");
            }
        }

        public void Delete(object id)
        {
            _mysSqlContext.Set<TEntity>().Remove(Select(id)!);
            _mysSqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mysSqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity? Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mysSqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }
    }
}