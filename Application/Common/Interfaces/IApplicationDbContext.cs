using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Company> Company { get; set; }
    DbSet<Fitting> Fitting { get; set; }
    DbSet<MmntList> MmntList { get; set; }
    DbSet<MmntPoint> MmntPoint { get; set; }
    DbSet<Style> Style { get; set; }
    DbSet<SizeRange> SizeRange { get; set; }
    DbSet<Size> Size { get; set; }
    DbSet<Grading> Grading { get; set; }



    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}