using System.Collections;

namespace Sem3;

public class CustomEnumerable : IEnumerable<int>
{
    private CustomEnumerator _enumerator = new CustomEnumerator();
    public IEnumerator<int> GetEnumerator() => _enumerator;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
}