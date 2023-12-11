namespace Sem5.Interface;

public interface ICalc
{
    void Sum(double a);
    void Div(double a);
    void Mul(double a);
    void Sub(double a);

    void Cancel();
    
    event EventHandler<EventArgs> Res;
}