using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace X.Dev.EntityFramework.Repositories
{
    public abstract class DevRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DevDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DevRepositoryBase(IDbContextProvider<DevDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DevRepositoryBase<TEntity> : DevRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DevRepositoryBase(IDbContextProvider<DevDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
