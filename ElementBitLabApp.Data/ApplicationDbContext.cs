using System.Threading;
using System.Threading.Tasks;
using ElementBitLabApp.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElementBitLabApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        
        public DbSet<ExcelData> ExcelDatas { get; set; }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
