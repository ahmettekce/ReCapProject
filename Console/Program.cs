using System;
using Business.Concrete;
using DataAccess.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            foreach (var car in productManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}
