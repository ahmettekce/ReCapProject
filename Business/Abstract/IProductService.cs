using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
    }
}
