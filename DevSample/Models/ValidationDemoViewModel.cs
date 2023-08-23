using System.ComponentModel.DataAnnotations;

namespace DevSample.Models
{
    public class ValidationDemoViewModel
    {
        [Range(0, 500)]
        public int IntMaxRange { get; set; }

        [Required]
        public string StringRequired { get; set; } = null!;

        [Required(AllowEmptyStrings = true)]
        public string StringRequiredButCanBeEmpty { get; set; } = null!;

        public string StringCanBeEmpty { get; set; } = null!;

        public string NullableStringCanBeEmpty { get; set; } = null!;

        public decimal Decimal { get; set; }

        [Required]
        [StringLength(8)]
        [MinLength(2)]
        public string StringLengthStrange { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime Date2022 { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAndTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? NUllableDateAndTime { get; set; }
    }
}
