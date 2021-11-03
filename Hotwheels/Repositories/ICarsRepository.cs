using Hotwheels.Entities;
using System.Collections.Generic;

namespace Hotwheels.Repositories
{
    public interface ICarsRepository
    {
        Car GetCar(int id);
        IEnumerable<Car> GetCars();
        void CreateCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);    
    }
}