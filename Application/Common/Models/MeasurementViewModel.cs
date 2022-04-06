using Domain.Common.Enums;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class MeasurementViewModel
    {

        public int Id { get; set; }
        public int? ParentMeasurementId { get; set; }
        public Measurement? ParentMeasurement { get; set; }
        public string Name { get; set; } = null!;
        public SizeRange SizeRange { get; set; } = null;
        public ICollection<MeasurementPoint> MeasurementPoints { get; set; } = new List<MeasurementPoint>();
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        public int? StyleId { get; set; }
    }
}
