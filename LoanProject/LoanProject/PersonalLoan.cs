using System;
namespace LoanProject
{
    public class PersonalLoan:Loan
    {
        public PersonalLoan(string loanNumber, string lastName, string firstName, double loanAmount, int term, double primeInterestRate)
            : base(loanNumber, lastName, firstName, loanAmount, term)
        {
            InterestRate = primeInterestRate + 2;
        }

        public override double CalculateTotalAmountOwed()
        {
            return LoanAmount + (LoanAmount * (InterestRate / 100));
        }
    }
}
