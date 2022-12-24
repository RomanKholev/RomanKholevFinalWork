// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами



string [] InitArray(int N)
{
    System.Console.WriteLine($"Введите {N} строк");
    string [] a=new string[N];
        for(int i=0;i<N;i++)
        a[i]=Convert.ToString(Console.ReadLine());
        return a;
}

void PrintArrey(string [] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.WriteLine($"{a[i],5}");
}