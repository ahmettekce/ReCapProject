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
