using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class ContactTypeRepository : RepositoryBase<ContactType>, IContactTypeRepository
    {
        public ContactTypeRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        //public ContactType GetTaskByName(string taskName)
        //{
        //    var task = this.DbContext.ContactTypes.Where(c => c.Name == taskName).FirstOrDefault();
     
        //    return task;
        //}
        public override void Update(ContactType entity)
        {        
            base.Update(entity);
        }
    }
    public interface IContactTypeRepository : IRepository<ContactType>
    {
       // Tasks GetTaskByName(string taskName);
    }
}
