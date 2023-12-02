using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Name.Length <= 3 ||car.DailyPrice < 0)
            {
                throw new Exception("Not saved");
            }
            _carDal.Add(car);

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByIdBrand(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<CarDetailDTO> GetCarDetail()
        {
           return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
