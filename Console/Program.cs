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

            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine($"Id: {car.Id}\naraç marka: {car.BrandName}\naraç rengi: {car.ColorName}\naracın ücreti: {car.DailyPrice}");
            }


        }
    }
}
