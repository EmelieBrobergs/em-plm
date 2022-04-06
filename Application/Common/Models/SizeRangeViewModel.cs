using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class SizeRangeViewModel
    {
        public int Id { get; set; }
        public ICollection<Size> Sizes { get; set; } = new List<Size>();
        public string BaseSizeName { get; set; } 
        public int MeasurementId { get; set; }
        //public Measurement Measurement { get; set; } = null!;
    }
}
