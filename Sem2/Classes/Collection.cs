using Microsoft.VisualBasic;

namespace Sem2;

public class Collection<T>: IIndexable<T>
{

    private T[] _arr;
    
    public T this[int index]
    {
        get => _arr[index];
        set => _arr[index] = value;
    }

    public Collection(int size)
    {
        _arr = new T[size];
    }
}