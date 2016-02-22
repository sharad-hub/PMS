using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public class ApplicationUserRepository : RepositoryBase<ApplicationUser>, IApplicationUserRepository
    {
        //IDbFactory dbFactory;
        public ApplicationUserRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
           // dbFactory = dbFactory;
        }
        public ApplicationUser GetUserById(string id) {
            return DbContext.Users.Where(x => x.Id == id).FirstOrDefault(); ;
        
        }
    }
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetUserById(string id);
    }


    //public abstract class UserBaseRepository
    //{
    //    #region Properties
    //    private CoreDbContext dataContext;
    //   // private readonly IDbSet<User> dbSet;

    //    protected IDbFactory DbFactory
    //    {
    //        get;
    //        private set;
    //    }

    //    protected CoreDbContext DbContext
    //    {
    //        get { return dataContext ?? (dataContext = DbFactory.Init()); }
    //    }
    //    #endregion

    //    protected UserBaseRepository(IDbFactory dbFactory)
    //    {
    //        DbFactory = dbFactory;
    //       // dbSet = DbContext.Set<T>();
    //    }
    //    public UserBaseRepository()
    //    {           
    //        DbFactory.Init() ;  
    //    }
    //    #region Implementation
    //    public virtual void Add(ApplicationUser entity)
    //    {
    //       // dbSet.Add(entity);
    //        dataContext.Users.Add(entity);
    //        dataContext.SaveChanges();
    //    }

    //    public virtual void Update(ApplicationUser entity)
    //    {
    //       // dbSet.Attach(entity);
    //    var entityToUpdate=dataContext.Users.Where(x=>x.Id==entity.Id).FirstOrDefault();
    //        entityToUpdate.IsApproved=entity.IsApproved;
    //        entityToUpdate.LastName=entity.LastName;
    //        entityToUpdate.LockoutEnabled=entity.LockoutEnabled;
    //        entityToUpdate.LockoutEndDateUtc=entity.LockoutEndDateUtc;
    //        dataContext.Entry(entity).State = EntityState.Modified;
    //        dataContext.SaveChanges();
    //    }

    //    public virtual void Delete(ApplicationUser entity)
    //    {
    //        dataContext.Users.Remove(entity);
    //        dataContext.SaveChanges();
    //    }

    //    public virtual void Delete(Expression<Func<ApplicationUser, bool>> where)
    //    {
    //        IEnumerable<ApplicationUser> objects = dataContext.Users.Where<ApplicationUser>(where).AsEnumerable();
    //        foreach (ApplicationUser obj in objects)
    //             dataContext.Users.Remove(obj);
    //          dataContext.SaveChanges();
    //    }

    //    public virtual ApplicationUser GetById(string id)
    //    {
    //        return dataContext.Users.Find(id);
    //    }

    //    public virtual IEnumerable<ApplicationUser> GetAll()
    //    {
    //        return dataContext.Users;
    //    }

    //    public virtual IEnumerable<ApplicationUser> GetMany(Expression<Func<ApplicationUser, bool>> where)
    //    {
    //        return dataContext.Users.Where(where).ToList();
    //    }

    //    public ApplicationUser Get(Expression<Func<ApplicationUser, bool>> where)
    //    {
    //        return dataContext.Users.Where(where).FirstOrDefault<ApplicationUser>();
    //    }

    //    #endregion
    
    //}
}

 
