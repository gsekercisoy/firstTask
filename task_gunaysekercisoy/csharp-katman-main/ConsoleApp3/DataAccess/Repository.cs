using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {   

        Context c = new Context();
        DbSet<T> _object;

        public Repository()
        {

            _object = c.Set<T>();


        }

        public List<T> List()
        {
            return _object.ToList();
        }
    }
}
