
//Дан массив и число.
//Найдите три числа в массиве сумма которых равна искомому числу.
//Подсказка: если взять первое число в массиве,
//можно ли найти в оставшейся его части два числа равных по сумме первому.

int[] arr = new []{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

int target = 200;
Console.WriteLine($"{target} - искомое число");
bool flag = false;
for (var i = 0; i < arr.Length; i++)
{
    for (var i1 = i+1; i1 < arr.Length; i1++)
    {
        for (var i2 = i1+1; i2 < arr.Length; i2++)
        {
            if (arr[i] + arr[i1] + arr[i2] == target)
            {
                flag = true;
                Console.WriteLine($"{arr[i]:D2} + {arr[i1]:D2} + {arr[i2]:D2} = {target}");
            }
        }
    }
}

if (!flag)
{
    Console.WriteLine("Чисел нет");
}