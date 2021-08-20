using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs.Emloyees;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEmployeesDal : IEntityRepository<Employees>
    {

    }
}
