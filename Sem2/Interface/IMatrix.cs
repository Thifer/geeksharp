namespace Sem2;

public interface IMatrix<T>
{
    T this[int row,int colum] { get; set; }
    void print();
}