using Hotwheels.Dtos;
using Hotwheels.Entities;
using Hotwheels.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotwheels.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController: ControllerBase
    {
        private readonly ICarsRepository _repository;

        public CarsController(ICarsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<CarDto> GetCars()
        {
            var cars = _repository.GetCars().Select(car=> car.AsDto());
            return cars;
        }
        [HttpGet("{id}")]
        public ActionResult<CarDto> GetCar(int id)
        {
            var car = _repository.GetCar(id);

            if(car is null)
            {
                return NotFound();
            }
            return Ok(car.AsDto());
        }

        [HttpPost]
        public ActionResult<CarDto> CreateCar(CreateCarDto carDto)
        {
            Car car = new()
            {
                Id = Guid.NewGuid(),
                Name = carDto.Name,
                Year = carDto.Year,
                Description = carDto.Description,
                Collection = carDto.Collection,
                SeriesNumber = carDto.SeriesNumber,
                CreatedDate = DateTime.Now,
                CarId = new Random().Next(int.MinValue, int.MaxValue)
            };

           _repository.CreateCar(car);
            return CreatedAtAction(nameof(GetCar), new { id = car.CarId }, car.AsDto() );
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCar(int id, UpdateCarDto carDto)
        {
            var car = _repository.GetCar(id);
            if(car == null)
            {
                return NotFound();
            }

            Car updatedCar = car with
            {
                Name = carDto.Name,
                Year = carDto.Year,
                Description = carDto.Description,
                Collection = carDto.Collection,
                SeriesNumber = carDto.SeriesNumber
            };

            _repository.UpdateCar(updatedCar);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCar(int id)
        {
            var car = _repository.GetCar(id);
            if (car == null)
            {
                return NotFound();
            }

            _repository.DeleteCar(car);
            return NoContent();
        }
    }
}
