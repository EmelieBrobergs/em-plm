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
        public int? AssignedToUserId { get; set; }//Vill presentera mer info om användaren
        public string Name { get; set; } = null!;

        [MaxLength(ErrorMessage = "Maximum {1} characters allowed")]
        public string Description { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public string ProductGroup { get; set; } = null!;

        public List<string> Tags { get; set; } = null!;
        //public ICollection<MeasurementViewModel> Measurements { get; set; } = new List<MeasurementViewModel>();
        //public ICollection<FittingViewModel> Fittings { get; set; } = new List<FittingViewModel>();

        public int CompanyId { get; set; }
        //public Company Company { get; set; } = null!;

        // TODO: FÄLT ATT LÄGGA TILL OCH POP MED DATA NÄR MEASUREMENT SKAPAS
        //public string SizeRangePrev     // laddas in när en ny measurement skapas/senaste uppdateras
        //public style BasedOnStyle       // vill visa styleNumber + StyleName i info/easy-info-box   - fältet måste uppdateras om based style skulle byta namn ex.
        //public ICollection<sample>? Samples   // registrerade samples på denna style... name + date i easy-info-box
    }
}
