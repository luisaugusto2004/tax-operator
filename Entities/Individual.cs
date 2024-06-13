namespace TaxOperator.Entities
{
    internal class Individual : TaxPayers
    {
        public double HealthRent { get; set; }

        public Individual(string name, double rent, double healthRent) : base(name, rent)
        {
            HealthRent = healthRent;
        }

        public override double TotalTax()
        {
            double Tax = 0;
            if (AnnualRent < 20000)
            {
                Tax = 0.15 * AnnualRent;
            } 
            else
            {
                Tax = 0.25 * AnnualRent;
            }
            double HealthTax = 0;
            if (HealthRent != 0)
            {
                HealthTax = 0.5 * HealthRent;
            }
            return Tax - HealthTax;
        }
    }
}
