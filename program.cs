public static void Main(string[] args)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Contract employee");
    Console.WriteLine("2. Permanent employee");

    int choice = Convert.ToInt32(Console.ReadLine());

    Employee employee;
    if (choice == 1)
    {
        Console.WriteLine("Enter the details (id, name, email, mobile number, agency, start date, end date)");
        string[] input = Console.ReadLine().Split(' ');

        employee = new ContractEmployee(
            Convert.ToInt32(input[0]),
            input[1],
            input[2],
            input[3],
            input[4],
            DateTime.ParseExact(input[5], "dd/MM/yyyy", null),
            DateTime.ParseExact(input[6], "dd/MM/yyyy", null)
        );
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the details (id, name, email, mobile number, salary)");
        string[] input = Console.ReadLine().Split(' ');

        employee = new PermanentEmployee(
            Convert.ToInt32(input[0]),
            input[1],
            input[2],
            input[3],
            Convert.ToDouble(input[4])
        );
    }
    else
    {
        Console.WriteLine("Invalid input");
        return;
    }

    employee.Display();
}
