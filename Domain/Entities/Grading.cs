using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Grading
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int Value { get; set; }  //Will be counted in relation to value of column "below", but re calculated when setting basic size....
    
    //Forigen key
    [ForeignKey("Size")]
    public int SizeId { get; set; }
    public Size Size { get; set; } = null!;
}
