using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class SampleMeasurementViewModel
    {
        public int Id { get; set; }
        public int? MeasurementPointId { get; set; }
        //public MeasurementPoint? MeasurementPoint { get; set; } = null!;
        public float Value { get; set; }
        public int SampleId { get; set; }
        //public Sample Sample { get; set; } = null!;
    }
}
