using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class SizeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int OrderdIndex { get; set; }

        public int SizeRangeId { get; set; }
        //public SizeRange SizeRange { get; set; } = null!;
    }
}
