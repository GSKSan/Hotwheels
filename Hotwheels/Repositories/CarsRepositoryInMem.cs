//using Hotwheels.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Hotwheels.Repositories
//{
//    public class CarsRepositoryInMem : ICarsRepository
//    {
//        private List<Car> cars = new List<Car>
//        {
//            new Car
//            {
//                Id = System.Guid.NewGuid(),
//                Name = "Car1",
//                CarId = 1,
//                Year = 2012,
//                Description = "Hotwheerls car",
//                CreatedDate = System.DateTime.UtcNow,
//                SeriesNumber = 1,
//                Collection = "new Collection"
//            },

//            new Car
//            {
//                CarId = 2,
//                Id = System.Guid.NewGuid(),
//                Name = "Car1",
//                Year = 2012,
//                Description = "Hotwheerls car",
//                CreatedDate = System.DateTime.UtcNow,
//                SeriesNumber = 1,
//                Collection = "new Collection"
//            },

//            new Car
//            {
//                CarId = 3,
//                Id = System.Guid.NewGuid(),
//                Name = "Car1",
//                Year = 2012,
//                Description = "Hotwheerls car",
//                CreatedDate = System.DateTime.UtcNow,
//                SeriesNumber = 1,
//                Collection = "new Collection"
//            }
//        };


//        public IEnumerable<Car> GetCars()
//        {
//            return cars;
//        }

//        public Car GetCar(int id)
//        {
//            return cars.Where(car => car.CarId == id).SingleOrDefault();
//        }

//        public void CreateCar(Car car)
//        {
//            cars.Add(car);
//        }

//        public void UpdateCar(Car car)
//        {
//            var index = cars.FindIndex(x => x.CarId == car.CarId );
//            cars[index] = car;
//        }

//        public void DeleteCar(Car car)
//        {
//            var index = cars.FindIndex(x => x.CarId == car.CarId);
//            cars.RemoveAt(index);
//        }
//    }
//}
