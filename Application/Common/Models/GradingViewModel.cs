using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class GradingViewModel
    {
        public int Id { get; set; }
        public int SizeId { get; set; }
        //public SizeViewModel Size { get; set; } = null!;
        public int MeasurementPointId { get; set; }
        //public MeasurementPointViewModel MeasurementPoint { get; set; } = null!;
        public float Value { get; set; }  //A clculated value in relation to OrderdIndex and base size.Only base size have an actual value... If baseSize changed, the value here will be converted...as well.
    }
}
