using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarGet();
            //ColorGet();
            //BrandGet();
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            if (result.Success==true )
            {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName+" "+car.BrandName+" "+car.ColorName);
            }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandGet()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorGet()
        {
            ColorManager colorManager = new ColorManager(new EFColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(brand.ColorName);
            //}
        }

        private static void CarGet()
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Name);
            //}
            //foreach (var car in carManager.GetByIdBrand(1))
            //{
            //    Console.WriteLine(car.Name + " " + car.DailyPrice);
            //}
            //carManager.Add(new Car { Id = 6, BrandId = 4, Name = "a", ColorId = 4, DailyPrice = 100, ModelYear = new DateTime(2019, 09, 01), Description = "Taycan Serisi" });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Name);
            //}
        }
    }
}