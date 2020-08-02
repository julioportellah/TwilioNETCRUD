using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context)
            : base(context)
        { }

        private AppDbContext AppDbContext
        {
            get { return Context as AppDbContext; }
        }
    }
}
