﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        
    }
}
