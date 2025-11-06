using System;

namespace LoanProject
{
    public abstract class Loan : ILoanConstant
    {
        public string LoanNumber { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFirstName { get; set; }
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int Term { get; set; }

        protected Loan(string loanNumber, string lastName, string firstName, double loanAmount, int term)
        {
            LoanNumber = loanNumber;
            CustomerLastName = lastName;
            CustomerFirstName = firstName;
            LoanAmount = loanAmount;
            Term = term;

            // Set the term to a valid value if it's not one of the defined terms
            if (Term != ((ILoanConstant)this).ShortTerm && Term != ((ILoanConstant)this).MediumTerm && Term != ((ILoanConstant)this).LongTerm)
            {
                Term = ((ILoanConstant)this).ShortTerm;
            }
        }
        string ILoanConstant.CompanyName
        {
            get { return "Your Company Name"; } // Replace with your actual company name
        }

        int ILoanConstant.ShortTerm
        {
            get { return 1; }
        }

        int ILoanConstant.MediumTerm
        {
            get { return 3; }
        }

        int ILoanConstant.LongTerm
        {
            get { return 5; }
        }

        public override string ToString()
        {
            return $"Loan Number: {LoanNumber}\n" +
                   $"Customer Name: {CustomerFirstName} {CustomerLastName}\n" +
                   $"Loan Amount: R{LoanAmount}\n" +
                   $"Interest Rate: {InterestRate}%\n" +
                   $"Term: {Term} years";
        }

        public abstract double CalculateTotalAmountOwed();
    }
}
