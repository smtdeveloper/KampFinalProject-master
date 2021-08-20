using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Emloyees;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfEmployeesDal : EfEntityRepositoryBase<Employees, NorthwindContext>, IEmployeesDal
    {

    }
}
