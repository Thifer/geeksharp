namespace Sem2;

public interface IIndexable<T>
{
    T this[int index] { get; set; }
}