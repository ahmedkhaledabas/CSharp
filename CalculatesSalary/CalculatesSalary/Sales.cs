namespace CalculatesSalary
{
    class Sales : Employee
    {
        protected decimal TotalSales {get; set;}
        protected decimal Commision {get; set;}
        
        public Sales(int id, string name, decimal loggedHours, decimal wage , decimal totalSales, decimal commision) : base(id, name, loggedHours, wage)
        {
            TotalSales = totalSales;
            Commision = commision;
        }

        public decimal CalcuBouns()
        {
            return TotalSales * Commision;
        }
        public override decimal CalcuNetSalary()
        {
            return base.CalcuBasicSalary() + CalcuBouns() + base.CalcuOverTime();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nCommision : ${Commision}" +
                $"\nBouns : ${CalcuBouns}" +
                $"\nNet Salary : ${CalcuNetSalary()}";
        }
    }
}