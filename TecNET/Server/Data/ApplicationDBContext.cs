using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TecNET.Shared.Models;

namespace TecNET.Server.Data
{
        public class QuestionsDBContext : DbContext
        {
            public QuestionsDBContext(DbContextOptions<QuestionsDBContext> options) : base(options)
            {
            }
            public DbSet<Questions> Question { get; set; }
        }

}
