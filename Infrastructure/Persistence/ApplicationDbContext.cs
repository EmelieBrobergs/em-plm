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
    public virtual DbSet<Respond> Responds { get; set; } = null!;
    public virtual DbSet<Sample> Samples { get; set; } = null!;
    public virtual DbSet<SampleMeasurement> SampleMeasurements { get; set; } = null!;


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

        modelBuilder.Entity<Style>().HasIndex(s => new { s.StyleNumber, s.CompanyId }).IsUnique(true);

        modelBuilder.Entity<MeasurementPoint>().HasIndex(m => new { m.ShortName, m.MeasurementId }).IsUnique(true);

        // TODO: Skriva constrain för Grading. g = new { g.SizeId, g.MeasurementPointId }

        modelBuilder.Entity<Style>()
            .Property(e => e.Tags)
            .HasConversion(
                v => string.Join(',', v), // send to db
                v => new List<string>(v.Split(',', StringSplitOptions.RemoveEmptyEntries))); // fetch from db
    }
}
