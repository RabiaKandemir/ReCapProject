using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
            foreach (var car in carManager.GetById(1))
            {
                Console.WriteLine(car.Description+" "+car.DailyPrice);
            }
            carManager.Add(new Car { Id = 4, BrandId = 3, ColorId = 3, DailyPrice = 157000, ModelYear = new DateTime(2020), Description = "Öfkeli" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
            }
        }
    }
}