using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

    DbSet<Company> Companies { get; set; }
    DbSet<Fitting> Fittings { get; set; }
    DbSet<Measurement> Measurements { get; set; }
    DbSet<MeasurementPoint> MeasurementPoints { get; set; }
    DbSet<Style> Styles { get; set; }
    DbSet<SizeRange> SizeRanges { get; set; }
    DbSet<Size> Sizes { get; set; }
    DbSet<Grading> Gradings { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}