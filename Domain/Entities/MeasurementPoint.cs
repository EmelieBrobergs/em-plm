using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class MeasurementPoint
    {
        public int Id { get; set; }
        [MaxLength(5, ErrorMessage = "Maximum {1} characters allowed")]
        public string ShortName { get; set; } = null!;
        [MaxLength(60, ErrorMessage = "Maximum {1} characters allowed")]
        public string Description { get; set; } = null!;
        public float? Tolerance { get; set; }

        public int? MeasurementId { get; set; }
        public Measurement? Measurement { get; set; }

    }
}
