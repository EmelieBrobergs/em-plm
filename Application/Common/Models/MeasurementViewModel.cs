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
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        // public Measurement? ParentMeasurement { get; set; }
        public string Name { get; set; } = null!;
        public SizeRangeViewModel? SizeRange { get; set; } = null;
        //public ICollection<MeasurementPointViewModel> MeasurementPoints { get; set; } = new List<MeasurementPointViewModel>();
        public UnitOfMeasureEnum UnitOfMeasure { get; private set; } = 0;
        public int? StyleId { get; set; }
    }
}
