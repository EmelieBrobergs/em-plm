using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class RespondViewModel
    {
        public int Id { get; set; }
        public int MeasurementId { get; set; }
        //public Measurement Measurement { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime CreatedDate { get; private set; }

        public int? NextMeasurementId { get; set; }  // Optional bacause it is not decided what to do in initial state...
        //public Measurement? NextMeasurement { get; set; }

        public ICollection<SampleViewModel> Samples { get; set; } = new List<SampleViewModel>();
    }
}
