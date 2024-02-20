namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDBContext applicationDBContext = new ApplicationDBContext();

            applicationDBContext.Employees.Add(new() { EmpName = "Ahmed", Salary = 1000d });

            applicationDBContext.Employees.Add(new() { EmpName = "Khaled", Salary = 2000d });

            applicationDBContext.SaveChanges();
        }
    }
}
