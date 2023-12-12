// See https://aka.ms/new-console-template for more information

using Sem5.Class;

static void CalcGotRes2(object sender, EventArgs args)
{
    Console.WriteLine($"resul = {((Calc)sender).GetRes:0000.00}");
}

static void newcalc(Action<double> action)
{
    Console.WriteLine("Введите следущие число");
    try
    {
        action.Invoke(double.Parse(Console.ReadLine()));
    }
    catch (CalculatorDivideByZeroException e)
    {
        Console.WriteLine(e);
    }
    catch (CalculateOperationCauseOverflowException e)
    {
        Console.WriteLine(e);
    }
}

Console.WriteLine("Введите первое число");
var calc = new Calc(double.Parse(Console.ReadLine()));
calc.Res += CalcGotRes2;
while (true)
{
    Console.WriteLine("Выберите действие(+-*/), либо ничего для выхода");
    switch (Console.ReadLine().ToLower())
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
        case "q":
            return;
    }
}