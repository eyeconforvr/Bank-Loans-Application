using System;

namespace LoanProject
{
    enum Menu
    {
        BusinessLoan=1,
        PersonalLoan
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*************** Unique Building Services Loan Company ***************\n");
                Console.Write("Current Prime Interest Rate (Whole Number e.g 10): ");
                double primeInterestRate = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Loan[] loans = new Loan[5];

                for (int i = 0; i < loans.Length; i++)
                {
                    Console.WriteLine("*************** Loan Type ***************\n1. Business Loan\n2. Personal Loan ");
                    int loanType = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Loan Number: ");
                    string loanNumber = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Loan Amount: ");
                    double loanAmount = Convert.ToDouble(Console.ReadLine());

                    while (loanAmount>100000)                                 // loop until the entered amount is not over 100000
                    {
                        Console.Write("Loan cannot exceed R100000\nPlease enter a new amount:");
                        loanAmount = double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("*************** Loan Term ***************\n1. Short Term (1 year)\n3. Medium Term (3 years)\n5. Long Term (5 years)");
                    int term = int.Parse(Console.ReadLine());

                    switch ((Menu)loanType)
                    {
                        case Menu.BusinessLoan:
                            loans[i] = new BusinessLoan(loanNumber, lastName, firstName, loanAmount, term, primeInterestRate);
                            break;
                        case Menu.PersonalLoan:
                            loans[i] = new PersonalLoan(loanNumber, lastName, firstName, loanAmount, term, primeInterestRate);
                            break;
                    }
                    Console.Clear();
                }

                Console.WriteLine("*************** Current Open Loans ***************\n");

                foreach (Loan loan in loans)
                {
                    Console.WriteLine(loan.ToString());
                    Console.WriteLine("Total Amount Owed: R" + loan.CalculateTotalAmountOwed());
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured, please try again later..." + ex.Message);      // catch error and display error message at the end
                Console.ReadLine();
            }

        }
    }
}
