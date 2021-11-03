using Hotwheels.Dtos;
using Hotwheels.Entities;

namespace Hotwheels
{
    public static class Extensions
    {
        public static CarDto AsDto(this Car car)
        {
            return new CarDto
            {
                CarId = car.CarId,
                Id = car.Id,
                Name = car.Name,
                Year = car.Year,
                Description = car.Description,
                Collection = car.Collection,
                SeriesNumber = car.SeriesNumber,
                CreatedDate = car.CreatedDate
            };
        }
    }
}
