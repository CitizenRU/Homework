Console.WriteLine("Введите первое число");
int count1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int count2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int count3 = Convert.ToInt32(Console.ReadLine());
int max = count1;
if (max < count2) max = count2;
if (max < count3) max = count3;

System.Console.WriteLine("Максимальное из этих чисел = " + max);