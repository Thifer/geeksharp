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
        Reset();
        return false;
    }

    public void Reset() => Current = -1;

    public int Current { get; private set; } = -1;

    object IEnumerator.Current => -1;

    public void Dispose()
    {
    }
}