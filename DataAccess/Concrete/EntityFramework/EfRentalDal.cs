using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapContext>, IRentalDal
    {

        public List<RentalDetailDTO> GetRentalsDetails(Expression<Func<RentalDetailDTO, bool>> filter = null)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                                 on r.CarId equals c.Id
                             join cu in context.Customers
                                 on r.CustomerId equals cu.Id
                             join u in context.Users
                                 on cu.Id equals u.Id
                             join b in context.Brands
                                 on c.BrandId equals b.Id
                             select new RentalDetailDTO
                             {
                                 Id = r.Id,
                                 CarName = c.Name,
                                 CustomerName = cu.CompanyName,
                                 ReturnDate = r.ReturnDate,
                                 RentDate = r.RentDate

                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
