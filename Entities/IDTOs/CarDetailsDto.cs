using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entities.IDTOs
{
    public class CarDetailsDto:IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
