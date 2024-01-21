namespace CalculatesSalary
{
    class Employee
    {
        public Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }
        
        private const decimal AdditionalHoursRate = 1.25m;
        private const int WorkDays = 22;
        private const int WorkHours = 8;
        private const int MinimumHoursRequired = WorkDays * WorkHours;
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        public decimal CalcuAdditionalHours()
        {
            return LoggedHours - MinimumHoursRequired;
        }
        public virtual decimal CalcuBasicSalary()
        {
            if(LoggedHours >= MinimumHoursRequired)
            {
            return MinimumHoursRequired * Wage;
            }
            else
            {
                return LoggedHours * Wage;
            }
        }

        public decimal CalcuOverTime()
        {
            return CalcuAdditionalHours() * AdditionalHoursRate * Wage;
        }

        public virtual decimal CalcuNetSalary()
        {
            return 0;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("CalculatesSalary.", "");
            return $" {type} " +
                     $"\nID : {Id}" +
                     $"\nName : {Name}" +
                     $"\nLogged Hours : {LoggedHours} Hrs" +
                     $"\nWage : {Wage} $/Hr"+
                     $"\nBase Salary : ${CalcuBasicSalary()}" +
                     $"\nExtra Hours : {CalcuAdditionalHours()} Hrs" +
                     $"\nOver Time : ${CalcuOverTime()}";
        }
    }
}