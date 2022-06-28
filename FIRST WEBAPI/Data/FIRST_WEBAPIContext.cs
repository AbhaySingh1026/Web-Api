using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FIRST_WEBAPI;

namespace FIRST_WEBAPI.Data
{
    public class FIRST_WEBAPIContext : DbContext
    {
        public FIRST_WEBAPIContext (DbContextOptions<FIRST_WEBAPIContext> options)
            : base(options)
        {
        }

        public DbSet<FIRST_WEBAPI.Employee>? Employee { get; set; }
    }
}
