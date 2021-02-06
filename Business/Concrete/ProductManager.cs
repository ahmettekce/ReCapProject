using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _productDal.GetById(id);
        }

        
    }
}
