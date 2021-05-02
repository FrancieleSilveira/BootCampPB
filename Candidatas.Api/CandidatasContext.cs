using Microsoft.EntityFrameworkCore;
using Candidatas.Api.Models;

namespace Candidatas.Api.Data
{
    public class CandidatasContext : DbContext
    {
        public CandidatasContext(DbContextOptions<CandidatasContext> options)
            : base (options)
        {
        }

        public DbSet<Interessada> Interessadas { get; set; }
    }
}