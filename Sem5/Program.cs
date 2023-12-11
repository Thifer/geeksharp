// See https://aka.ms/new-console-template for more information

using Sem5.Class;

static void CalcGotRes2(object sender,EventArgs args)
{
    Console.WriteLine($"resul = {((Calc)sender).GetRes}");
}

static void newcalc(Action<double> action)
{
    Console.WriteLine("Введите следущие число");
    action(double.Parse(Console.ReadLine()));
}

Console.WriteLine("Введите первое число");
Calc calc = new Calc(double.Parse(Console.ReadLine()));
calc.Res += CalcGotRes2;
while (true)
{
    Console.WriteLine("Выберите действие(+-*/), либо ничего для выхода");
    switch (Console.ReadLine())
    {
        case "+":
            newcalc(calc.Sum);
            break;
        case "-":
            newcalc(calc.Sub);
            break;
        case "*":
            newcalc(calc.Mul);
            break;
        case "/":
            newcalc(calc.Div);
            break;
        case "":
            return; 
    }
}


