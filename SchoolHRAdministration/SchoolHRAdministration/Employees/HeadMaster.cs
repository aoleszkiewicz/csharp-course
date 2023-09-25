using HRAdministrationAPI;

namespace SchoolHRAdministration;

public class HeadMaster : EmployeeBase
{
    public override decimal Salary => base.Salary + (base.Salary * 0.05m);
}