using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
           _cars = new List<Car> {
        new Car(){Id=1,ColorId="#ff0000",BrandId=1,DailyPrice=1000,ModelYear="2011",Description="Ferrari 458 Italia"},
        new Car(){Id=2,ColorId="#0000ff",BrandId=2,DailyPrice=250,ModelYear="2018",Description="Ford Focus"},
        new Car(){Id=3,ColorId="#a62c2b",BrandId=3,DailyPrice=120,ModelYear="2013",Description="Alfa Romeo Guiliatta"},
        new Car(){Id=4,ColorId="#ffffff",BrandId=4,DailyPrice=90,ModelYear="2021",Description="Opel Corsa"},

        };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int carId)
        {
            Car carToDelete = _cars.FirstOrDefault(c => c.Id == carId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c=>c.Id==carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
