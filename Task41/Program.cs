/* Пользователь вводит М чисел. 
Посчитайте, сколько чисел больше 0 ввел пользователь.*/
Console.Clear();
Console.Write("Введите количество чисел:");
int m = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < m; i++)
{
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine(count);