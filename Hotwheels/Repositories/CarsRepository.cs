using Hotwheels.Entities;
using Hotwheels.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotwheels.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private readonly IMongoCollection<Car> _cars;

        public CarsRepository(IHotWheelsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cars = database.GetCollection<Car>(settings.HotWheelsCollectionName);
        }

        public IEnumerable<Car> GetCars()
        {
            return _cars.Find(car => true).ToList();
        }

        public Car GetCar(int id)
        {
            return _cars.Find<Car>(car => car.CarId == id).FirstOrDefault();
        }

        public void CreateCar(Car car)
        {
            _cars.InsertOne(car);
        }

        public void UpdateCar(Car car)
        {
            _cars.ReplaceOne(car => car.CarId == car.CarId, car);
        }

        public void DeleteCar(Car car)
        {
            _cars.DeleteOne(car => car.CarId == car.CarId);
        }
    }
}
