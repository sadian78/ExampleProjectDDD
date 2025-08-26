using Microsoft.EntityFrameworkCore;

namespace ExampleProjectDDD.Infrastructure.Context
{
    internal sealed class WriteDBContext : DbContext
    {
        public WriteDBContext(DbContextOptions<WriteDBContext> options) : base(options)
        {

        }
    }
}
