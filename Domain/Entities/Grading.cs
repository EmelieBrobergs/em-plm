using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

// NOTE: Composit key of MmntPointid + SizeId, entity/table could be named "MmntPointSize" by convention..

public class Grading
{
    public int Id { get; set; }

    public int SizeId { get; set; }
    public Size Size { get; set; } = null!;


    public int MeasurementPointId { get; set; }
    public MeasurementPoint MeasurementPoint { get; set; } = null!;

    public float Value { get; set; }  //A clculated value in relation to OrderdIndex and base size.Only base size have an actual value... If baseSize changed, the value here will be converted...as well.
}
