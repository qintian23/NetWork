using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace FurionHello.EntityFramework.Core
{
    [AppDbContext("FurionHello", DbProvider.Sqlite)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}