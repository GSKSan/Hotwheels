using System.ComponentModel.DataAnnotations;

namespace Hotwheels.Dtos
{
    public class CreateCarDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Year { get; set; }
        public string Description { get; set; }
        [Required]
        public string Collection { get; set; }
        [Required]
        public int SeriesNumber { get; set; }
    }
}
