using FirstServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstServer.Data
{
    public class FirstServerDbcontext : DbContext
    {


        public DbSet<Models.DAT_Production> DAT_Production { get; set; }
        public DbSet<Models.BLZDYNR> BLZDYNR { get; set; }

        public DbSet<D_ASRRool> D_ASRRool { get; set; }

        public FirstServerDbcontext(DbContextOptions<FirstServerDbcontext> options)
            : base(options)
        { }

    }
}
