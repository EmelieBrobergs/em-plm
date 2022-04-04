using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class EditStyleViewModel
    {
        public int Id { get; set; }
        public string StyleNumber { get; set; } = null!;
        public string OrderNumber { get; set; } = null!;
        public int CompanyId { get; set; }
        public int? AssignedToUserId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public string ProductGroup { get; set; } = null!;
        public List<string> Tags { get; set; } = null!;
    }
}
