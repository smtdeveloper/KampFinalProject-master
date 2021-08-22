using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.Emyloyees
{
    public class EmployeesAddDto : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; } // İşe Alma Tarihi
        public string Country { get; set; }
        public string City { get; set; }
        public string HomePhone { get; set; }
        public string Address { get; set; }
        public string PhotoPath
        {
            get; set;
        }
}
}
