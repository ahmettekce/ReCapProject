using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    interface IProductService
    {
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
    }
}
