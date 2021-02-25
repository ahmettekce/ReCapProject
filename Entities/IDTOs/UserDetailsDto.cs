using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.IDTOs
{
    public class UserDetailsDto : IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }
}
