using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Style> Styles { get; set; } = new List<Style>();
    }
}
