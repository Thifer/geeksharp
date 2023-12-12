using Sem5.Interface;

namespace Sem5.Class;

/*
 * В прошлой лекции мы реализовали метод CancelLast позволяющий отменить любое сделанное действие.
 * Реализуйте класс - список, описывающий последовательность действий приведших исключению.
 * Очевидно что класс калькулятора должен быть доработан чтобы хранить не только информацию необходимую
 * нам для отмены но и информацию о самом действии. Продумайте как лучше это реализовать. Пример:
 */

public enum CalcActions
{
    Sum,
    Sub,
    Mul,
    Div
}

public class Calc : ICalc
{
    private readonly Stack<CalcActionLog> _actionLogs = new();
    private readonly Stack<double> _results = new();

    public Calc(double value = 0)
    {
        GetRes = value;
        _results.Push(GetRes);
    }

    public double GetRes { get; private set; }

    public void Sum(int a)
    {
        Sum((double)a);
    }

    public void Sum(double a)
    {
        if (GetRes + a > double.MaxValue)
        {
            _actionLogs.Push(new CalcActionLog(CalcActions.Sum, a));
            throw new CalculateOperationCauseOverflowException("Переполнение", _actionLogs);
        }

        _results.Push(GetRes);
        GetRes += a;
        RaiseEvent();
    }

    public void Div(int a)
    {
        Div((double)a);
    }

    public void Div(double a)
    {
        if (a == 0)
        {
            _actionLogs.Push(new CalcActionLog(CalcActions.Div, a));
            throw new CalculatorDivideByZeroException("Деление на 0", _actionLogs);
        }

        if (GetRes / a > double.MaxValue)
        {
            _actionLogs.Push(new CalcActionLog(CalcActions.Sum, a));
            throw new CalculateOperationCauseOverflowException("Переполнение", _actionLogs);
        }

        _results.Push(GetRes);
        GetRes /= a;
        RaiseEvent();
    }

    public void Mul(int a)
    {
        Mul((double)a);
    }

    public void Mul(double a)
    {
        if (GetRes * a > double.MaxValue)
        {
            _actionLogs.Push(new CalcActionLog(CalcActions.Mul, a));
            throw new CalculateOperationCauseOverflowException("Переполнение", _actionLogs);
        }

        _results.Push(GetRes);
        GetRes *= a;
        RaiseEvent();
    }

    public void Sub(int a)
    {
        Sub((double)a);
    }

    public void Sub(double a)
    {
        if (GetRes - a < double.MinValue)
        {
            _actionLogs.Push(new CalcActionLog(CalcActions.Sub, a));
            throw new CalculateOperationCauseOverflowException("Слишком в минус", _actionLogs);
        }

        _results.Push(GetRes);
        GetRes -= a;
        RaiseEvent();
    }

    public void Cancel()
    {
        if (_results.Count > 0) GetRes = _results.Pop();
        RaiseEvent();
    }

    public event EventHandler<EventArgs>? Res;

    private void RaiseEvent()
    {
        Res?.Invoke(this, EventArgs.Empty);
    }
}