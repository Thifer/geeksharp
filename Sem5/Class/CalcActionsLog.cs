namespace Sem5.Class;

public class CalcActionLog
{
    public CalcActionLog(CalcActions calcActions, double calcArgument)
    {
        CalcActions = calcActions;
        CalcArgument = calcArgument;
    }

    public CalcActions CalcActions { get; private set; }
    public double CalcArgument { get; private set; }
}