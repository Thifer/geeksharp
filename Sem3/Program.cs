// See https://aka.ms/new-console-template for more information

using System.Collections;
using Sem3;

/*List<int> list = new (){1,2,3,4,5};
Stack<int> stack = new (list);
//Console.WriteLine(string.Join(" ",_list));
list.Clear();
while (stack.Count > 0)
{
    list.Add(stack.Pop());
}
//Console.WriteLine(string.Join("",_list));

var customEnumerable = new CustomEnumerable();
foreach (var x in customEnumerable)
{
    Console.WriteLine(x);
}

Console.WriteLine();
foreach (var x in customEnumerable)
{
    Console.WriteLine(x);
}
*/


/*Есть лабиринт описанный в виде двумерного массива где 1 это стены, 0 - проход, 2 - искомая цель.
Пример лабиринта:
1 1 1 1 1 1 1
1 0 0 0 0 0 1
1 0 1 1 1 0 1
0 0 0 0 1 0 2
1 1 0 0 1 1 1
1 1 1 1 1 1 1
1 1 1 1 1 1 1
Напишите алгоритм определяющий наличие выхода из лабиринта и выводящий на экран  координаты точки выхода если таковые имеются.*/

Stack<Tuple<int,int>> _path = new Stack<Tuple<int,int>>();

int[,] labirynth1 = new int[,]
{
    {1, 1, 1, 1, 1, 1, 1 },
    {1, 0, 0, 0, 0, 2, 1 },
    {1, 0, 1, 1, 1, 0, 1 },
    {2, 0, 0, 0, 1, 0, 2 },
    {1, 1, 0, 0, 1, 1, 1 },
    {1, 1, 1, 2, 1, 1, 1 },
    {1, 1, 1, 1, 1, 1, 1 }
};



Console.WriteLine(FindPath(1, 1));


int FindPath(int i, int j)
{
    int count = 0;
    if (labirynth1[i, j] == 0) _path.Push(new (i,j));
    
    while (_path.Count>0)
    {
        
        var current = _path.Pop();
        if (labirynth1[current.Item1, current.Item2] == 2)
        {

            count++;
        }

        labirynth1[current.Item1, current.Item2] = 1;
        
        if(current.Item1+1<labirynth1.GetLength(0) 
           && labirynth1[current.Item1+1,current.Item2]!=1)
            _path.Push(new(current.Item1+1,current.Item2));
        
        if(current.Item2+1<labirynth1.GetLength(1) &&
           labirynth1[current.Item1,current.Item2+1]!=1 )
            _path.Push(new(current.Item1,current.Item2+1));
        
        if( current.Item1>0 && labirynth1[current.Item1-1,current.Item2]!=1 )
            _path.Push(new(current.Item1-1,current.Item2));
        
        if( current.Item2>0 && labirynth1[current.Item1,current.Item2-1] != 1 )
            _path.Push(new(current.Item1,current.Item2-1));
    }

    
    return count;

}


