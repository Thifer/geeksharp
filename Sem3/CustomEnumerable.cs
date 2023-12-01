using System.Collections;

namespace Sem3;

public class CustomEnumerable : IEnumerable<int>
{
    private int[] _arr;
    public IEnumerator<int> GetEnumerator() => new CustomEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
}