// Задача 40: Напишите программу, которая принимает
//  на вход три числа и проверяет, может ли существовать 
//  треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая 
// сторона треугольника меньше суммы двух других сторон.
// || - или && - и

// Console.WriteLine("Введите 1 число");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int num2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите 3 число");
// int num3 = int.Parse(Console.ReadLine());

// if(num1<num2+num3 && num2<num1+num3 && num3<num2+num1)
// {
//   Console.WriteLine("Можно построить треугольник");  
// }
// else Console.WriteLine("Нельзя построить треугольник");


// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// string result= "";
// while(num>0)
// {
//   result =  num%2 + result;
//   num = num/2;
// }
// Console.WriteLine(result);


// Задача 44: Не используя рекурсию, выведите первые 
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int firstNum =0;
// int secondNum =1;

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// Console.Write(firstNum+ " " +secondNum+" ");
// for (int i = 2; i <= num; i++)
// {
//   int nextNum = firstNum+secondNum;
//   Console.Write(nextNum+ " ");
//   firstNum=secondNum;
//   secondNum=nextNum;
// }


// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом
//  месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом
//   месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int[] array = new int[num];

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(0,10);
    System.Console.Write(array[i]+ " ");
}

for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] =array[array.Length-1-i];
    array[array.Length-1-i]=temp;
}

System.Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i]+ " ");
}