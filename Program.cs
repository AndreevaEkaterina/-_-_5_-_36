// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] RandomArray()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void PrintArray(int[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
        Console.Write($"{N[i]}");
        if (i != N.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
int SumOdd(int[] Ar)
{
    int sum = 0;
    for (int i = 1; i < Ar.Length; i++)
    {
        if (i % 2>0)
        {
            sum = sum + Ar[i];
        }
    }

    return sum;
}
Console.Clear();
int[] Mass = RandomArray();
PrintArray(Mass);
Console.Write($" => {SumOdd(Mass)}");