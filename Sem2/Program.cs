// See https://aka.ms/new-console-template for more information

using Sem2;

var collection = new Collection<string>(10);

collection[0] = "new string";
collection[1] = "new string1";


Bits bit = new(100);
var bitInt = new Bits(10);
var bitByte = new Bits((byte)11);
var bitLong = new Bits((long)12);

long _long = bitLong;
int _int = bitInt;
byte _byte = bitByte;


Console.WriteLine(_long.GetType());
Console.WriteLine(_long);
Console.WriteLine(_int.GetType());
Console.WriteLine(_int);
Console.WriteLine(_byte.GetType());
Console.WriteLine(_byte);