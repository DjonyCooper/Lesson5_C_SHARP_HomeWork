// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2
/*
int [] CreativeNewArray(int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i=0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal+1);
    }
    return array;
}

void ShowArroy(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindEvenNum(int [] array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {  
            count++;    
        }        
    }
    return count;
}

Console.Write("Здравствуйте, задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int [] newArray = CreativeNewArray(size, min, max);
ShowArroy(newArray);

Console.Write($"Число чётных чисел в массиве равно: {FindEvenNum(newArray)}");
*/
// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Пример: [3, 7, 23, 12] -> 19
//         [-4, -6, 89, 6] -> 0
/*
int [] CreativeNewArray(int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i=0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal+1);
    }
    return array;
}

void ShowArroy(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOddNum(int [] array)
{   

    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i%2 != 0)
        {
            sum += array[i];
        }        
    }
    return sum;
}

Console.Write("Здравствуйте, задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int min = -999;
int max = 999;

int [] newArray = CreativeNewArray(size, min, max);
ShowArroy(newArray);

Console.Write($"Сумма чисел, стоящих на нечетных позициях, равна: {SumOddNum(newArray)}");
*/
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Пример: [3.0 7.2 22.7 2.1 78.3] -> 76.2
/*
double [] CreativeNewArray(int size, int minVal, int maxVal)
{
    double [] array = new double[size];
    for (int i=0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal+1) + new Random().NextDouble();
    }
    return array;
}

void ShowArroy(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

double SumOddNum(double [] array)
{   
    double maxNum = array[0];
    double minNum = array[0];
    double diff = 0;
    for(int i = 0; i < array.Length; i++)
    {   
        if(maxNum <= array[i]) {maxNum = array[i];}
        if(minNum >= array[i]) {minNum = array[i];}
        diff = maxNum - minNum;        
    }
    return diff;
}

Console.Write("Здравствуйте, задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int min = -20;
int max = 20;

double [] newArray = CreativeNewArray(size, min, max);
ShowArroy(newArray);
string diff = SumOddNum(newArray).ToString("F1");
Console.Write($"Разница между максимальным и минимальным элементом массива, равна: {diff}");
*/