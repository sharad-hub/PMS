using Core.Data.Infrastructure;
using Core.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repositories
{
    public class ToDoRepository : RepositoryBase<ToDo>, IToDoRepository
    {
        public ToDoRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IToDoRepository : IRepository<ToDo>
    {
    }
}
