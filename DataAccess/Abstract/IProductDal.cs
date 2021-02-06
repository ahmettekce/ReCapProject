using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        List<Car> GetById(int id);
    }
}
