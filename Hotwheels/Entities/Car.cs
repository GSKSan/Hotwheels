using System;

namespace Hotwheels.Entities
{
    public record Car
    {
        public Guid Id { get; init; }
        public int CarId {  get; init; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description {  get; set; }
        public string Collection { get; set; }
        public int SeriesNumber { get; set; }
        public DateTime CreatedDate {  get; set; }

    }
}
