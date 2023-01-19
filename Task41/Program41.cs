// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Console.WriteLine("Введите количество чиел:");
int [] createArray(int [] array)
{
  for (int i = 0; i < array.Length; i++)  
  {
    Console.WriteLine($"Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
  return array;
}
//int count = 0;
int plus(int [] array)
{
    int count = 0;
    foreach (int a in array)
    {
      if (a > 0)
      count++;
    }
    return count;
}
int numCount = new Random().Next(1,10);
int [] numbers = new int [numCount];

Console.WriteLine(createArray(numbers));
Console.WriteLine($"{plus(numbers)} чисел больше нуля ");