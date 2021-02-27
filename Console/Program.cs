using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFremawork;
using Entities.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdd();

            //UserAdd();

            //Rental();
        }

        private static void Rental()
        {
            RentalManager rentalManager = new RentalManager(new EfRental());
            Rental rental = new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 24) };
            rentalManager.RentCar(rental);
            rentalManager.ReturnCar(rental, new DateTime(2021, 02, 25));
        }

        private static void UserAdd()
        {
            UserManager user = new UserManager(new EfUser());
            //user.Add(new User { FirstName = "Engin", LastName = "Demiroğ", Email = "engindemirog@gmail.com", Password = "12345" });

            var result = user.GetAll();

            if (result.Success)
            {
                foreach (var u in result.Data)
                {
                    System.Console.WriteLine(u.FirstName + " " + u.LastName);
                }
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCar());
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine(car.BrandName);
                }

            }
        }
    }
}
