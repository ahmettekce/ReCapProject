using Core.DataAccess;
using Core.Utilities.Result;
using Entities.Concrete;
using Entities.IDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        List<RentalDetailsDto> GetDetailDto();
    }
}
