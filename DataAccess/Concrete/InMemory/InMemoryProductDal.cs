using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal:IProductDal
    {
        private List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 50,ModelYear = 2019,Description="Bmw Hasarsız",},
                new Car{Id = 2,BrandId = 2,ColorId = 1,DailyPrice = 30,ModelYear = 2016,Description="Audi Hasarsız"},
                new Car{Id = 3,BrandId = 2,ColorId = 2,DailyPrice = 40,ModelYear = 2016,Description="Audi Hasarsızlı"},
                new Car{Id = 4,BrandId = 2,ColorId = 3,DailyPrice = 60,ModelYear = 2020,Description="Mercedes Hasarsızlı"},
                new Car{Id = 5,BrandId = 3,ColorId = 2,DailyPrice = 80,ModelYear = 2021,Description="Bmw Hasarsız"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }
    }
}
