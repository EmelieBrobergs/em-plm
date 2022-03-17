using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class MmntList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum {1} characters allowed")]
        public string Name { get; set; } = null!;

        public SizeRange SizeRange { get; set; } = null!;
        
        public List<MmntPoint> MmntPoints { get; set; } = null!; // om mmntList raderas ska även mmntPoint tas bort, skapa koppling
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        
        public int? BasedOnMmntListId { get; set; }
        [ForeignKey("MmntList")]
        public MmntList? BasedOnMmntList { get; set; } 
        public int? StyleId { get; set; }
        //Foreign key 
        [ForeignKey("StyleId")]
        public Style? Style { get; set; } = null!;
    }
}
