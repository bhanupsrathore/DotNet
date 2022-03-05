namespace Taxation;

public interface ITaxPayer
{
    decimal AnnualIncome();

    decimal IncomeTax()
    {
        decimal e = AnnualIncome() - 120000;
        return e > 0 ? 0.15M * e : 0;
    }
}