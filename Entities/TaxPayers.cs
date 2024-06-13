namespace TaxOperator.Entities
{
    internal abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnnualRent { get; set; }

        public TaxPayers(string name, double Rent)
        {
            Name = name;
            AnnualRent = Rent;
        }

        public abstract double TotalTax();

    }
}
