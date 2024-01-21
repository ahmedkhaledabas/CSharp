namespace CalculatesSalary
{
    class Developer : Employee
    {
        private const decimal Bouns = 0.03m;
        protected bool TaskCompleted { get; set; }
        

        public Developer(int id, string name, decimal loggedHours, decimal wage , bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            TaskCompleted = taskCompleted;
        }

        public decimal CalcuBouns()
        {
            return Bouns * base.CalcuBasicSalary();
        }
        public override decimal CalcuNetSalary()
        {
            if (TaskCompleted)
            {
            return base.CalcuBasicSalary() + CalcuBouns() + base.CalcuOverTime();

            }else 
            return base.CalcuBasicSalary() + base.CalcuOverTime();
        }

        public override string ToString()
        {
            return base.ToString() +
                $" \nTask Completed : ${(TaskCompleted ? "YES" : "NO")}" +
                $"\nBouns : ${CalcuBouns()}" +
                $"\nNet Salary : ${CalcuNetSalary()}";
        }
    }
}