using System;

class Employee
{
    protected int employeeId;
    protected string name;
    protected string email;
    protected string mobileNumber;

    public Employee()
    {
    }

    public Employee(int employeeId, string name, string email, string mobileNumber)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.email = email;
        this.mobileNumber = mobileNumber;
    }

    public virtual void Display()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine("Employee Id: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Mobile Number: " + mobileNumber);
    }
}

class ContractEmployee : Employee
{
    private string agencyName;
    private DateTime startDate;
    private DateTime endDate;

    public ContractEmployee()
    {
    }

    public ContractEmployee(int employeeId, string name, string email, string mobileNumber, string agencyName, DateTime startDate, DateTime endDate)
        : base(employeeId, name, email, mobileNumber)
    {
        this.agencyName = agencyName;
        this.startDate = startDate;
        this.endDate = endDate;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Agency Name: " + agencyName);
        Console.WriteLine("Start Date: " + startDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("End Date: " + endDate.ToString("dd/MM/yyyy"));
    }
}

class PermanentEmployee : Employee
{
    private double salary;

    public PermanentEmployee()
    {
    }

    public PermanentEmployee(int employeeId, string name, string email, string mobileNumber, double salary)
        : base(employeeId, name, email, mobileNumber)
    {
        this.salary = salary;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Salary: " + salary);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Contract employee");
        Console.WriteLine("2. Permanent employee");

        if (args.Length != 1 || (!int.TryParse(args[0], out int choice)) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.WriteLine("Enter the details (id, name, email, mobile number" + (choice == 1 ? ", agency, start date, end date)" : ", salary)"));

        string[] input = Console.ReadLine().Split(',');

        if (input.Length < 4)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int employeeId;
        if (!int.TryParse(input[0], out employeeId))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        string name = input[1].Trim();
        string email = input[2].Trim();
        string mobileNumber = input[3].Trim();

        if (choice == 1)
        {
            if (input.Length < 7)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string agencyName = input[4].Trim();
            if (!DateTime.TryParseExact(input[5].Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime startDate))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            if (!DateTime.TryParseExact(input[6].Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime endDate))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            ContractEmployee contractEmployee = new ContractEmployee(employeeId, name, email, mobileNumber, agencyName, startDate, endDate);
            contractEmployee.Display();
        }
        else if (choice == 2)
        {
            if (!double.TryParse(input[4].Trim(), out double salary))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            PermanentEmployee permanentEmployee = new PermanentEmployee(employeeId, name, email, mobileNumber, salary);
            permanentEmployee.Display();
        }
    }
}
