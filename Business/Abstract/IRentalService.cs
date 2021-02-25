using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult RentCar(Rental rental);
        IResult ReturnCar(Rental rental, DateTime returnDate);
    }
}
