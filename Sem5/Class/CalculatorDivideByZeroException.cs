namespace Sem5.Class;

public class CalculatorDivideByZeroException : CalcException
{
    public CalculatorDivideByZeroException(string s,Stack<CalcActionLog> calcActionLogs) : base(s,calcActionLogs)
    {
    }

    public CalculatorDivideByZeroException(string s, Exception e) : base(s, e)
    {
    }
}