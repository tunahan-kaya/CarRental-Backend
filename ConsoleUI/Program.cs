using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ReCapProject 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car { Id = 2, BrandId = 3, DailyPrice = 500, ModelYear = "2017", ColorId = "ff0000", Description = "Alfa Romeo Giulia" });
            carManager.Delete(2);
            carManager.Update(new Car { Id = 2, BrandId = 3, DailyPrice = 500, ModelYear = "2017", ColorId = "ff0000", Description = "Alfa Romeo Giulia Quadrifoglio" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------------------");
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
