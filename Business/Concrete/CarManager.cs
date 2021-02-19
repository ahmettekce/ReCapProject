using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                if (car.Description.Length > 2)
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine(Message.CarDescriptionInvalid);
                }
            
            }
            else
            {
                Console.WriteLine(Message.CarDailyPriceInvalid);
            }
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                if (car.Description.Length > 2)
                {
                    _carDal.Update(car);
                }
                else
                {
                    Console.WriteLine(Message.CarDescriptionInvalid);
                }

            }
            else
            {
                Console.WriteLine(Message.CarDailyPriceInvalid);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
