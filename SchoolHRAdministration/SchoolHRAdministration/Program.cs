using HRAdministrationAPI;
using SchoolHRAdministration.Enums;
using SchoolHRAdministration.Factories;


List<IEmployee> employeesList = new List<IEmployee>();
SeedData(employeesList);

Console.WriteLine($"Total Salaries: {employeesList.Sum(employee => employee.Salary)}");

void SeedData(List<IEmployee> employees)
{
    IEmployee teacher1 = EmployeeFactory.CreateEmployeeInstance(EmployeeType.Teacher, 1, "John", "Doe", 5000);
    IEmployee teacher2 = EmployeeFactory.CreateEmployeeInstance(EmployeeType.Teacher, 2, "Jane", "Doe", 5500);
    IEmployee headOfDepartment = EmployeeFactory.CreateEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Jack", "Doe", 6000);
    IEmployee deputyHeadMaster = EmployeeFactory.CreateEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Jill", "Doe", 6500);
    IEmployee headMaster = EmployeeFactory.CreateEmployeeInstance(EmployeeType.HeadMaster, 5, "James", "Doe", 7000);
    
    employees.Add(teacher1);
    employees.Add(teacher2);
    employees.Add(headOfDepartment);
    employees.Add(deputyHeadMaster);
    employees.Add(headMaster);
}



