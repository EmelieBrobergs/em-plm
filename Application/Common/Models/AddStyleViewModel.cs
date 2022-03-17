using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class AddStyleViewModel
    {
        public int CompanyId { get; set; }
        public int? AssignedToUserId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public string ProductGroup { get; set; } = null!;
        public List<MmntList>? MmntLists { get; set; } = null!; // Ska denna vara med här?
    }
}
