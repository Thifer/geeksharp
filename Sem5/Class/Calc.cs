using Sem5.Interface;

namespace Sem5.Class;

public class Calc : ICalc
{
    public double GetRes { get; private set; } = 0;

    private Stack<double> results = new Stack<double>();
    
    public void Sum(double a)
    {
        results.Push(GetRes);
        GetRes += a;
        RaiseEvent();
    }

    public void Div(double a) {
        results.Push(GetRes);
        GetRes /= a;
        RaiseEvent();
        
    }

    public void Mul(double a) {
        results.Push(GetRes);
        GetRes *= a;
        RaiseEvent();
        
    }
    public void Sub(double a) {
        results.Push(GetRes);
        GetRes -= a;
        RaiseEvent();
    }

    public void Cancel()
    {
        if(results.Count>0)
            GetRes = results.Pop();
        RaiseEvent();
    }


    public event EventHandler<EventArgs>? Res;


    private void RaiseEvent() => Res?.Invoke(this, EventArgs.Empty);
    
    public Calc(double value = 0)
    {
        GetRes = value;
        results.Push(GetRes);
    }
}