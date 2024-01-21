namespace CalculatesSalary
{
    class Maintenance : Employee
    {
        private const decimal HardShip = 100m;
        public Maintenance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }
        private const decimal Allowance = 0.05m;

        public override decimal CalcuNetSalary()
        {
            return base.CalcuBasicSalary() + HardShip + base.CalcuOverTime();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nHardship : ${HardShip}" +
                $"\nNet Salary : ${CalcuNetSalary()}";
        }
    }
}