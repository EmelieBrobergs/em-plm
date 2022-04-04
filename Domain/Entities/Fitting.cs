using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fitting
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum {1} characters allowed")]
        public string Name { get; set; } = null!;
        //public Array[]? Images { get; set; }  // hur ska detta sparasi db ? bilder ? format ?
        [MaxLength(ErrorMessage = "Maximum {1} characters allowed")]
        public string Comment { get; set; } = null!;

        public int StyleId { get; set; }
        public Style Style { get; set; } = null!;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
    }
}
