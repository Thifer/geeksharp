namespace Sem5.Class;

public class CalcException : Exception
{
    public Stack<CalcActionLog> CalcActionLog;
    
    public override string ToString()
    {
        return Message + ": " + 
               string.Join("\n", CalcActionLog.Select(x => $"{x.CalcActions} {x.CalcArgument}"));
    }

    public CalcException(string s,Stack<CalcActionLog> actionLogs) : base(s)
    {
        CalcActionLog = actionLogs;
    }

    public CalcException(string s, Exception e) : base(s, e)
    {
    }
}