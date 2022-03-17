using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Size
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int OrderdIndex { get; set; }
        public List<Grading>? Gradings { get; set; }

        //Foreign key 
        [ForeignKey("SizeRange")]
        public int SizeRangeId { get; set; }
        public SizeRange SizeRange { get; set; } = null!;
    }
}
