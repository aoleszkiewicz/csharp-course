using HRAdministrationAPI;
using SchoolHRAdministration.Enums;

namespace SchoolHRAdministration.Factories;

public class EmployeeFactory
{
    public static IEmployee CreateEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName,
        decimal salary)
    {
        IEmployee employee = null;

        switch (employeeType)
        {
            case EmployeeType.Teacher:
                employee = FactoryPattern<IEmployee, Teacher>.CreateInstance();
                break;
            case EmployeeType.HeadOfDepartment:
                employee = FactoryPattern<IEmployee, HeadOfDepartment>.CreateInstance();
                break;
            case EmployeeType.DeputyHeadMaster:
                employee = FactoryPattern<IEmployee, DeputyHeadMaster>.CreateInstance();
                break;
            case EmployeeType.HeadMaster:
                employee = FactoryPattern<IEmployee, HeadMaster>.CreateInstance();
                break;
            default:
                break;
        }

        if (employee != null)
        {
            employee.Id = id;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Salary = salary;
        }
        else
        {
            throw new NullReferenceException();
        }
        
        return employee;
    }
}