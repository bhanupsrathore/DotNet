using Payroll;

double IncomeTax(Employee emp)
{
    double i = emp.Income(); //dynamic binding for virtual method
    return i > 10000 ? 0.15 * (i - 10000) : 0; 
}

void Appraise(Employee emp)
{
    if(emp is SalesPerson)
    {
        SalesPerson sp = (SalesPerson)emp; //explicit down-casting
        emp.HourlyRate *= sp.Sales >= 75000 ? 1.10f : 1.0f;
    }
    else
    {
        emp.HourlyRate *= emp.Hours >= 175 ? 1.12f : 1.0f;
    }
}

Employee jack = new Employee();
jack.Hours = 186; //jack.set_Hours(186)
jack.HourlyRate = 52;
Console.WriteLine("Jack's Income is {0:0.00} and Tax is {1:0.00}", jack.Income(), IncomeTax(jack));
SalesPerson jill = new SalesPerson(186, 52, 64000);
Console.WriteLine("Jill's Income is {0:0.00} and Tax is {1:0.00}", jill.Income(), IncomeTax(jill));
Appraise(jack);
Appraise(jill);
Console.WriteLine("Jack's Income after appraisal: {0:0.00}", jack.Income());
Console.WriteLine("Jill's Income after appraisal: {0:0.00}", jill.Income());
Console.WriteLine("Number of Employees = {0}", Employee.CountInstances());

