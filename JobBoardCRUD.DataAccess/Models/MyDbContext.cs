using JobBoardCRUD.DataAccess.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace JobBoardCRUD.DataAccess.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options){}
        public DbSet<Job> Job { get; set; }
    }
}
