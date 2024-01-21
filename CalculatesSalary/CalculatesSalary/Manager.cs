namespace CalculatesSalary
{
    class Manager : Employee
    {
        public Manager(int id, string name, decimal loggedHours, decimal wage) :base(id, name, loggedHours, wage)
        {
            
        }
        private const decimal Allowance = 0.05m;

        public decimal CalcuAllowance()
        {
            return base.CalcuBasicSalary() * Allowance ;
        }

        public override decimal CalcuNetSalary()
        {
            return base.CalcuBasicSalary() + CalcuAllowance() + base.CalcuOverTime();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nAlowance : ${CalcuAllowance()}" +
                $"\nNet Salary : ${CalcuNetSalary()}";
        }
    }
}