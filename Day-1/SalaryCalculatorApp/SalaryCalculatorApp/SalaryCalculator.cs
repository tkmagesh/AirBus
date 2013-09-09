namespace SalaryCalculatorApp
{
    public class SalaryCalculator
    {
        private double _basic;
        public double Basic
        {
            set
            {
                _basic = value;
            }
            get { return _basic; }
        }

        public double Hra { get; set; }
        public double Da { get; set; }
        public double Tax { get; set; }

        public double Salary { private set; get; }

        public void Calculate()
        {
            double gross = Basic + Hra + Da;
            double net = gross*((100 - Tax)/100);
            Salary = net;
        }
        
    }
}