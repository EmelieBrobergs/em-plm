using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class MmntPoint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(5, ErrorMessage = "Maximum {1} characters allowed")]
        public string ShortName { get; set; } = null!;
        [MaxLength(30, ErrorMessage = "Maximum {1} characters allowed")]
        public string Description { get; set; } = null!;
        public int? Tolerance { get; set; }

        //Forigen key
        [ForeignKey("Grading")]
        public int? GradingId { get; set; }
        public Grading? Grading { get; set; } = null!;

        //Foreign key 
        [ForeignKey("MmntList")]
        public int MmntListId { get; set; }
        public MmntList MmntList { get; set; } = null!;
    }
}
