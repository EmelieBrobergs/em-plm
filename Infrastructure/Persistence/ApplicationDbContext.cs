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

    public virtual DbSet<Company> Company { get; set; } = null!;
    public virtual DbSet<Fitting> Fitting { get; set; } = null!;
    public virtual DbSet<MmntList> MmntList { get; set; } = null!;
    public virtual DbSet<MmntPoint> MmntPoint { get; set; } = null!;
    public virtual DbSet<Style> Style { get; set; } = null!;
    public virtual DbSet<SizeRange> SizeRange { get; set; } = null!;
    public virtual DbSet<Size> Size { get; set; } = null!;
    public virtual DbSet<Grading> Grading { get; set; } = null!;





    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
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

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasIndex(e => e.Name).IsUnique();
        });

        modelBuilder.Entity<MmntPoint>(entity =>
        {
            entity.HasIndex(e => e.ShortName).IsUnique();
        });


        //modelBuilder.Entity<MmntList>().Property<string[]>("SizeRange").IsRowVersion().HasColumnName("SizeRange");

        //modelBuilder.Entity<MmntPoint>(dob =>
        //{
        //    dob.ToTable("MmntList");
        //    dob.Property(o => o.SizeRange).HasColumnName("SizeRange");
        //    dob.HasIndex(e => e.ShortName).IsUnique();
        //});

        //modelBuilder.Entity<MmntList>(ob =>
        //{
        //    ob.ToTable("MmntList");
        //    ob.Property(o => o.SizeRange).HasColumnName("SizeRange");
        //    ob.HasOne(o => o.MmntPoints).WithOne()
        //    .HasForeignKey<List<MmntPoint>>();
        //});
    }
}
