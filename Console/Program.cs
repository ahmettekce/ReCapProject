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
            ProductManager productManager = new ProductManager(new EfCar());

            foreach (var car in productManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }


        }
    }
}
