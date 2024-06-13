using TaxOperator.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace TaxOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());  
            List<TaxPayers> list = new List<TaxPayers>();

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char payer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(payer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, health));
                } else if (payer == 'c')
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add(new LegalEntity(name, income, number));
                }
            }
            Console.WriteLine();
            double sum = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayers taxPayer in list)
            {
                sum += taxPayer.TotalTax();
                Console.WriteLine(taxPayer.Name + ": $ "+taxPayer.TotalTax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
