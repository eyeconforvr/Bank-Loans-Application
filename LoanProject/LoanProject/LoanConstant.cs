using System;
namespace LoanProject
{
    public interface ILoanConstant
    {
        string CompanyName { get; }
        int ShortTerm { get; }
        int MediumTerm { get; }
        int LongTerm { get; }
    }
}
