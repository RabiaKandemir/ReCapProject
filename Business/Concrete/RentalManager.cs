﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var isCarRented = _rentalDal.Get(r => r.ReturnDate == null && r.CarId == rental.CarId);

            if (isCarRented != null)
            {
                return new ErrorResult(Messages.RentalCarError);
            }
            _rentalDal.Add(rental);
            return new SuccesResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccesResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
           return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id==id));
        }

        public IDataResult<List<Rental>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        public IDataResult<List<RentalDetailDTO>> GetRentalDetail()
        {
            return new SuccessDataResult<List<RentalDetailDTO>>(_rentalDal.GetRentalsDetails(), Messages.RentalDetailsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccesResult(Messages.RentalUpdated);
        }
    }
}
