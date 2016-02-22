using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Data.Repositories
{
    public class ContactPersonRepository : RepositoryBase<ContactPerson>, IContactPersonRepository
    {
        public ContactPersonRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
        //public Tasks GetTaskByName(string taskName)
        //{
        //    var task = this.DbContext.Tasks.Where(c => c.Name == taskName).FirstOrDefault();

        //    return task;
        //}
        public override void Update(ContactPerson entity)
        {
            //entity.UpdatedOn = DateTime.Now;
            //entity.ModifiedBy = entity.ModifiedBy;
            base.Update(entity);
        }
    }
    public interface IContactPersonRepository : IRepository<ContactPerson>
    {
      //  Tasks GetTaskByName(string taskName);
    }
}
