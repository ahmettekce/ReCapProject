using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.IDTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<CarDetailsDto> GetCarDetails();

    }
}
