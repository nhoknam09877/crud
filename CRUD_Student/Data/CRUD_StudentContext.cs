using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Student.Models;

namespace CRUD_Student.Data
{
    public class CRUD_StudentContext : DbContext
    {
        public CRUD_StudentContext (DbContextOptions<CRUD_StudentContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Student.Models.Students> Students { get; set; } = default!;
    }
}
