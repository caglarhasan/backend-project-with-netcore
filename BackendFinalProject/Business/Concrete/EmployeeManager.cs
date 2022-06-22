using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        [ValidationAspect(typeof(Employee))]
        public IResult Add(Employee employee)
        {

            _employeeDal.Add(employee);

            return new SuccessResult(Messages.EmployeeAdded);
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll(), Messages.EmployeeListed);
        }

        public IDataResult<Employee> GetById(int id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(e => e.EmployeeId == id), Messages.EmployeeListed);
        }
    }
}
