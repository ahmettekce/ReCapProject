﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFremawork
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,ReCapContext>, IBrandDal
    {
        
    }
}
