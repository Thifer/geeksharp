namespace Sem2;

public class Collection<T> : IIndexable<T>
{
    private readonly T[] _arr;

    public Collection(int size)
    {
        _arr = new T[size];
    }

    public T this[int index]
    {
        get => _arr[index];
        set => _arr[index] = value;
    }
}