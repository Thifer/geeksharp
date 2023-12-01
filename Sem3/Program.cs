// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Threading.Channels;
using Sem3;

List<int> _list = new (){1,2,3,4,5};
Stack<int> _stack = new (_list);
Console.WriteLine(string.Join(" ",_list));
_list.Clear();
while (_stack.Count > 0)
{
    _list.Add(_stack.Pop());
}
Console.WriteLine(string.Join("",_list));

CustomEnumerable _customEnumerable = new CustomEnumerable();

foreach (var item in _customEnumerable)
{
    Console.WriteLine(item);
}
