using GameON.Core.IRepositories;

namespace GameON.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}