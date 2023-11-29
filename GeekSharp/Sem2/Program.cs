using System.Threading.Channels;
using Microsoft.VisualBasic;
using Sem2;

namespace Sem2;
public class Program
{
    public static void Main()
    {
        Collection<string> collection = new Collection<string>(10);

        collection[0] = "new string";
        collection[1] = "new string1";


        Bits bit = new(100);
        Bits bitInt = new Bits((int)10);
        Bits bitByte = new Bits((byte)11);
        Bits bitLong = new Bits((long)12);

        long _long = bitLong;
        int _int = bitInt;
        byte _byte = bitByte;


        Console.WriteLine(_long.GetType());
        Console.WriteLine(_long);
        Console.WriteLine(_int.GetType());
        Console.WriteLine(_int);
        Console.WriteLine(_byte.GetType());
        Console.WriteLine(_byte);


    }
}
