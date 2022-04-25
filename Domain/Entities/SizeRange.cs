namespace Domain.Entities
{
    // TODO: Lista ut hur denna ska skrivas/kopplas !
    public class SizeRange
    {
        public int Id { get; set; }

        public ICollection<Size> Sizes { get; set; } = new List<Size>();

        public string BaseSizeName { get; set; } = null!; //Hur ska denna variabel hanteras?, om inga Sizes = 0 ? om sizes loopa igenom och välj 38 / M som storlek by defult. Justera till valfri... "Typ en FK ??"

        public int MeasurementId { get; set; }
        public Measurement Measurement { get; set; } = null!;
    }
}
