// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 3

// 1, -7, 567, 89, 223-> 4

Console.Clear();

Console.Write($"Введите количество чисел М: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[M];

void InputNumbers(int M){
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Compare(int[] ArrayNumbers)
{
  int count = 0;
  for (int i = 0; i < ArrayNumbers.Length; i++)
  {
    if(ArrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
InputNumbers(M);
Console.WriteLine($"Введено чисел больше 0: {Compare(ArrayNumbers)} ");