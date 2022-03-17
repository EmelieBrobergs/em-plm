using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class MmntListViewModel
    {
        public string Name { get; set; } = null!;
        public SizeRange SizeRange { get; set; } = null!;
        public UnitOfMeasureEnum UnitOfMeasure { get; set; }
        public int? StyleId { get; set; }
    }
}
