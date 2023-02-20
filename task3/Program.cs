//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("задайте номер четверти");
int number = int.Parse(Console.ReadLine());
if (number == 1) Console.WriteLine("x>0,y>0");
else if (number == 2) Console.WriteLine("x<0,y>0");
else if (number == 3) Console.WriteLine("x<0,y<0");
else if (number == 4) Console.WriteLine("x>0,y<0");
else Console.WriteLine("вышли за дипазон");

