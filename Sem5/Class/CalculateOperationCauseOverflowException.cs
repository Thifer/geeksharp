namespace Sem5.Class;

public class CalculateOperationCauseOverflowException : CalcException
{
    public CalculateOperationCauseOverflowException(string e,Stack<CalcActionLog> calcActionLogs) : base(e,calcActionLogs)
    {
    }

    public CalculateOperationCauseOverflowException(string s, Exception e) : base(s, e)
    {
    }
}