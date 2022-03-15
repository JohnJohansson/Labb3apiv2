using Labb3apiv2.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3apiv2.Data
{
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }

        public DbSet<Song>Songs { get; set; }
    }
}
