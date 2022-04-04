using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<
    AppUser,
    IdentityRole<int>, int,
    IdentityUserClaim<int>,
    IdentityUserRole<int>,
    IdentityUserLogin<int>,
    IdentityRoleClaim<int>,
    IdentityUserToken<int>
    >, IApplicationDbContext

{
    public ApplicationDbContext()
    {
    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }

    public virtual DbSet<Company> Companies { get; set; } = null!;
    public virtual DbSet<Fitting> Fittings { get; set; } = null!;
    public virtual DbSet<Measurement> Measurements { get; set; } = null!;
    public virtual DbSet<MeasurementPoint> MeasurementPoints { get; set; } = null!;
    public virtual DbSet<Style> Styles { get; set; } = null!;
    public virtual DbSet<SizeRange> SizeRanges { get; set; } = null!;
    public virtual DbSet<Size> Sizes { get; set; } = null!;
    public virtual DbSet<Grading> Gradings { get; set; } = null!;





    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();

        if (!optionsBuilder.IsConfigured)
        {
            // TODO: Vill fixa detta !!
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmPLM;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // added for aspNetCore.Identity, EF Code first
        new DbInitializer(modelBuilder).Seed();

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.HasIndex(e => e.Email).IsUnique();
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasIndex(e => e.Name).IsUnique();
        });

        //modelBuilder.Entity<MeasurementPoint>(entity =>
        //{
        //    entity.HasIndex(e => e.ShortName).IsUnique();  // NOTE: Funkar inte såhär!! Måste var combined keey isf..
        //});


        //modelBuilder.Entity<Grading>()
        //   .HasOne<Size>(e => e.Size)
        //   .WithMany(g => g.Gradings)
        //   .HasForeignKey(s => s.MmntPoint)
        //   .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<Grading>()
        //    .HasOne<MmntPoint>(e => e.MmntPoint)
        //    .WithMany(g => g.Gradings)
        //    .HasForeignKey(s => s.Size)
        //    .OnDelete(DeleteBehavior.NoAction);

        //modelBuilder.Entity<Grading>().Property(p => p.MmntPointId).ValueGeneratedNever();
        //modelBuilder.Entity<Grading>().Property(p => p.SizeId).ValueGeneratedNever();


        //modelBuilder.Entity<Grading>()
        //    .HasKey(g => new { g.MmntPointId, g.SizeId }); // composite key

        modelBuilder.Entity<Style>()
            .Property(e => e.Tags)
            .HasConversion(
                v => string.Join(',', v), //till db
                v => new List<string>(v.Split(',', StringSplitOptions.RemoveEmptyEntries))); //hämta från

        //v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
        //            .Distinct(StringComparer.OrdinalIgnoreCase)
        //            .ToArray(), new ValueComparer<ICollection<string>>(
        //            (c1, c2) => c1.SequenceEqual(c2),
        //            c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
        //            c => c.ToList()));

    }
}
