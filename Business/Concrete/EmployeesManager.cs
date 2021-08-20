using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.Emloyees;
using Entities.DTOs.Emyloyees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmployeesManager : IEmployeesService
    {

        private IEmployeesDal _employeesDal;

        public EmployeesManager(IEmployeesDal employeesDal)
        {
            _employeesDal = employeesDal;
        }

        public IResult Add(Employees emlooyeAdd)
        {
            _employeesDal.Add(emlooyeAdd);
            return new SuccessResult(Messages.EmployeesAdded);
        }

        public IResult Delete(Employees emlooyeDelete)
        {
            _employeesDal.Delete(emlooyeDelete);
            return new SuccessResult(Messages.EmployeesDeleted);
        }

        public IDataResult<List<Employees>> GetAll()
        {
            return new SuccessDataResult<List<Employees>>(_employeesDal.GetAll(), Messages.EmployeesGetall);
        }

        public IDataResult<Employees> GetById(int emlooyeId)
        {
          
            return new SuccessDataResult<Employees>(_employeesDal.Get(p => p.Id == emlooyeId), Messages.EmployeesGetId);
        }

        public IResult Update(Employees emlooyeUpdate)
        {
            _employeesDal.Update(emlooyeUpdate);
            return new SuccessResult(Messages.EmployeesUpdated);
        }
    }
}
