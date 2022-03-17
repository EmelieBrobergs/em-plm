using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
        // TODO: Lista ut hur denna ska skrivas/kopplas !
    public class SizeRange
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<Size> Sizes { get; set; } = null!;

        public int BaseSizeId { get; set; } //Hur ska denna variabel hanteras?

        //Foreign key 
        [ForeignKey("MmntList")]
        public int MmntListId { get; set; }
        public MmntList MmntList { get; set; } = null!;
    }
}
