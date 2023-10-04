public override void Display()
{
    base.Display();
    Console.WriteLine("Agency name: {0}", AgencyName);
    Console.WriteLine("Start date: {0}", StartDate.ToString("dd/MM/yyyy"));
    Console.WriteLine("End date: {0}", EndDate.ToString("dd/MM/yyyy"));
}
