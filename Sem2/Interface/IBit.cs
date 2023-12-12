namespace Sem2;

public interface IBit
{
    bool GetBitByIndex(byte index);
    void SetBitByIndex(byte index, bool value);
}

public class Bits : IBit
{
    public Bits(byte value)
    {
        Value = value;
        Size = sizeof(byte);
    }

    public Bits(int value)
    {
        Value = value;
        Size = sizeof(int);
    }

    public Bits(long value)
    {
        Value = value;
        Size = sizeof(long);
    }

    public long Value { get; private set; }

    public int Size { get; private set; }

    public bool this[byte index]
    {
        get => GetBitByIndex(index);
        set => SetBitByIndex(index, value);
    }


    public bool GetBitByIndex(byte index)
    {
        return (Value & (1 << index)) != 0;
    }

    public void SetBitByIndex(byte index, bool value)
    {
        if (value)
            Value |= (byte)(1 << index);
        else
            Value &= (byte)~(1 << index);
    }

    public static implicit operator long(Bits bits)
    {
        return bits.Value;
    }

    public static explicit operator Bits(long value)
    {
        return new Bits(value);
    }

    public static implicit operator byte(Bits bits)
    {
        return (byte)bits.Value;
    }

    public static explicit operator Bits(byte value)
    {
        return new Bits(value);
    }

    public static implicit operator int(Bits bits)
    {
        return (int)bits.Value;
    }

    public static explicit operator Bits(int value)
    {
        return new Bits(value);
    }
}