using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class StyleViewModel
    {
        public int Id { get; set; }
        public string StyleNumber { get; set; } = null!;
        public string OrderNumber { get; set; } = null!;
        public int? AssignedToUserId { get; set; }
        public string Name { get; set; } = null!;

        [MaxLength(ErrorMessage = "Maximum {1} characters allowed")]
        public string Description { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public string ProductGroup { get; set; } = null!;

        public List<string> Tags { get; set; } = null!;
        public ICollection<Measurement> Measurements { get; set; } = new List<Measurement>(); //var ska version av måttlista anges ? mha creation date ?
        public ICollection<Fitting> Fittings { get; set; } = new List<Fitting>();

        public int CompanyId { get; set; }
        //public Company Company { get; set; } = null!;
    }
}
