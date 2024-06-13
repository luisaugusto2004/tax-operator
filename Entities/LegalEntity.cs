namespace TaxOperator.Entities
{
    internal class LegalEntity : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public LegalEntity(string name, double rent, int numberOfEmployees) : base(name, rent)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TotalTax()
        {
            if(NumberOfEmployees < 10) 
            {
                return AnnualRent * 0.16;
            } else
            {
                return AnnualRent * 0.14;
            }
        }
    }
}
