using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Custormer:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
