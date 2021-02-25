using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
       
        public IResult RentCar(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Message.RentalAdded);
            }
            return new ErrorResult(Message.RentalReturnDateIsNull);
        }

        public IResult ReturnCar(Rental rental, DateTime returnDate)
        {
            rental.ReturnDate = returnDate;
            Console.WriteLine(rental.RentDate+ " - "+rental.ReturnDate);
          
            _rentalDal.Update(rental);
            return new SuccessResult(Message.RentalUpdated);
        }

    }
}
