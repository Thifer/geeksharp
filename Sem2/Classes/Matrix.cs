namespace Sem2;

public class Matrix<T>: IMatrix<T>
{


    private T[,] _matrix;
    
    public T this[int row, int colum]
    {
        get => _matrix[row,colum];
        set => _matrix[row,colum] = value;
    }

    public void print()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                Console.Write(_matrix[i,j]+"\t");
            }

            Console.WriteLine();
        }
    }


    public Matrix(int rowsize,int columsize)
    {
        _matrix = new T[rowsize, columsize];
    }
}