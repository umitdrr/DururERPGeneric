﻿using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Durur.Modules.Generic.DataAccess.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(ErpGenericDbContext context) : base(context) { }
    }
}
