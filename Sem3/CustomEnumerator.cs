using System.Collections;

namespace Sem3;

public class CustomEnumerator: IEnumerator<int>
{
    public bool MoveNext()
    {
        if (Current < 10)
        {
            Current++;
            return true;
        }
        return false;
    }

    public void Reset() => Current = 0;

    public int Current { get; private set; } = 0;

    object IEnumerator.Current => 0;

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}