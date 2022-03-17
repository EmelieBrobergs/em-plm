using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[Index("INDEX_UNIQUE_Name", IsUnique = true)]  TODO: Vill ha denna unik, tor jag gjort det i Context filen...
        public string Name { get; set; } = null!;
    }
}