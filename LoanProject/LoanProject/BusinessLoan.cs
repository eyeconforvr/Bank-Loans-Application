using System;
namespace LoanProject
{
    public class BusinessLoan:Loan
    {
        public BusinessLoan(string loanNumber, string lastName, string firstName, double loanAmount, int term, double primeInterestRate)
            : base(loanNumber, lastName, firstName, loanAmount, term)
        {
            InterestRate = primeInterestRate + 1;
        }

        public override double CalculateTotalAmountOwed()
        {
            return LoanAmount + (LoanAmount * (InterestRate / 100));
        }
    }
}