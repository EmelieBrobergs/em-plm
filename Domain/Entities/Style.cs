
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Entities
{
    public class Style
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int? AssignedToUserId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        [MaxLength(ErrorMessage = "Maximum {1} characters allowed")]
        public string Description { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public string ProductGroup { get; set; } = null!;
        
        //public List<string> Tags { get; set; } = null!; // string[] eller List<> ??
        public List<MmntList>? MmntLists { get; set; } = null!;   //var ska version av måttlista anges ? mha creation date ?
        public List<Fitting>? Fittings { get; set; }
        //Foreign key 
        [ForeignKey("CompanyId")]
        public Company Company { get; set; } = null!;
    }
}
