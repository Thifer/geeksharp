namespace Sem2;

public class Divice : IControlable
{
    public bool isOn { get; private set; }

    public void On()
    {
        isOn = true;
    }

    public void Off()
    {
        isOn = false;
    }
}

public class Devices
{
    public Devices()
    {
        DevicesList = new List<IControlable>();
        DevicesList.Add(new Divice());
        DevicesList.Add(new Divice());
        DevicesList.Add(new Divice());
        DevicesList.Add(new Divice());
        DevicesList.Add(new Divice());
        DevicesList.Add(new Divice());
        DevicesList.Add(new Divice());
        DevicesList.Add(new Divice());
    }

    public List<IControlable> DevicesList { get; set; }

    public void TurnOnOff(Bits bits)
    {
        //00000001
        //00000010
        //00000011
        //00000100
        //00000101
        //00000110
        //00000111
        //00001000
        //00001001
        //00001010


        for (byte i = 0; i < 8; i++)
            if (DevicesList[i].isOn && !bits[i])
                DevicesList[i].On();
            else if (!DevicesList[i].isOn && bits[i])
                DevicesList[i].Off();
    }

    public override string ToString()
    {
        return string.Join("", DevicesList.Select(s => s.isOn ? "1" : "0"));
    }
}