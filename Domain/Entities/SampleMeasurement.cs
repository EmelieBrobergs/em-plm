using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SampleMeasurement
    {
        public int Id { get; set; }
        public int? MeasurementPointId { get; set; }
        public MeasurementPoint? MeasurementPoint { get; set; } = null!;
        public float Value { get; set; }
        public int SampleId { get; set; }
        public Sample Sample { get; set; } = null!;
    }
}
