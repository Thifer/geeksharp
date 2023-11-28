namespace Sem2;

public interface IControlable
{
    public bool isOn { get; }
    void On();
    void Off();
}