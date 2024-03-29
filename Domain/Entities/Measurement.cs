﻿using Domain.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Measurement
    {
        public Measurement()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; private set; }
        public int? ParentMeasurementId { get; set; }
        public Measurement? ParentMeasurement { get; set; }


        [MaxLength(50, ErrorMessage = "Maximum {1} characters allowed")]
        public string Name { get; set; } = null!;

        public SizeRange? SizeRange { get; set; } = null;

        public ICollection<MeasurementPoint> MeasurementPoints { get; set; } = new List<MeasurementPoint>();
        // om mmntList raderas ska även mmntPoint tas bort, skapa koppling
        public UnitOfMeasureEnum UnitOfMeasure { get; private set; } = 0;

        public int? StyleId { get; set; }  //Om null så blir det dålig/föräldralös data i db...!? Svårt med dessa kopplingar i denna app..
        public Style? Style { get; set; } = null!;
    }
}
