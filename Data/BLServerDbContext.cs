using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstServer.Data
{
    public class BLServerDbContext:DbContext
    {

        public BLServerDbContext(DbContextOptions<FirstServerDbcontext> options)
            : base(options)
        { }


    }
}
