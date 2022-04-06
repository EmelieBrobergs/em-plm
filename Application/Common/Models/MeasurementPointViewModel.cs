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
    public class MeasurementPointViewModel
    {
        public int Id { get; set; }
        public string ShortName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public float? Tolerance { get; set; }

        public int? MeasurementId { get; set; }
        //public Measurement? Measurement { get; set; }
    }
}
