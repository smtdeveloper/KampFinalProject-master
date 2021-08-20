using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.Emloyees;
using Entities.DTOs.Emyloyees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IEmployeesService 
    {
        IDataResult<List<Employees>> GetAll();
        IDataResult<Employees> GetById(int emlooyeId);
        IResult Add(Employees emlooyeAdd);
        IResult Update(Employees emlooyeUpdate);
        IResult Delete(Employees emlooyeDelete);
    }
}
