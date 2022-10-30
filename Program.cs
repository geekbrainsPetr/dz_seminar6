
//пользователь вводит с клавиатуры числа. сколько чисел больше нуля ввел пользователь

/*
int[] MNumbers(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void ShowArray(int[] array)???
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void MoreZero(int[] array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
          count++;
        }
    }    
    Console.WriteLine($"Кол-во элементов больше 0 -> {count}");
    
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] NewArray = MNumbers(a);
ShowArray(NewArray);
MoreZero(NewArray);
*/



// точка пересечения прямых

void InterPoint(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    if(k1 == k2) 
    Console.WriteLine("Прямые не пересекаются");
    else
    Console.WriteLine($"Прямые пересекаются в точке - > ({x};{y})");
}

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

InterPoint(k1, b1, k2, b2);

