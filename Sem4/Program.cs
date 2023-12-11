

string[] names = {"asd","csa","zxs","iqs","aws"};

var task = names.Where(x => x.StartsWith("a"));

Console.WriteLine(string.Join(" ",task));

names[2] = "axs";

Console.WriteLine(string.Join(" ",task));