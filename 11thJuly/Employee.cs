using System;
using System.Dynamic;

class Employee
{
   public int Id;
    public string EmpName;
   public  double MonthlySalary;


    Employee(int i,string e,double s)
    {
        Id=i;
        EmpName=e;
        MonthlySalary=s;
    }

    double CalculateAnnualSalary()
    {
        return MonthlySalary=12;
    }
    
}