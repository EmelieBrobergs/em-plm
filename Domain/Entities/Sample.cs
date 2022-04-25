using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RespondId { get; set; }
        public Respond Respond { get; set; } = null!;
        public int? SizeId { get; set; }
        public Size? Size { get; set; }
        public ICollection<SampleMeasurement> SampleMeasurements { get; set; } = new List<SampleMeasurement>();
    }
}
