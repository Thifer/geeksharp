using System.Collections;

namespace Sem3;

public class CustomEnumerable : IEnumerable<int>
{
    private readonly CustomEnumerator _enumerator = new();

    public IEnumerator<int> GetEnumerator()
    {
        return _enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}