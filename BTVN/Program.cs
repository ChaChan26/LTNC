//bai 1 12/09/26

using System;
using System.Collections.Generic;


int[] ar = { 67, 911, 324, 23423, 4324, 14, 34 };

ar[2] = 100;
foreach (var x in ar)
{
  Console.WriteLine(x);
}

Console.WriteLine("Hello World!");
int a;
int b;
int c;
Console.Write("nhap a: ");
a = Convert.ToInt32(Console.ReadLine());
while (true)
{
  Console.Write("nhap b: ");
  try
  {
    b = Convert.ToInt32(Console.ReadLine());
    break;
  }
  catch (Exception)
  {
    Console.WriteLine("nhap sai, nhap lai");
  }
}
while (true)
{
  Console.Write("nhap c: ");
  bool k = int.TryParse(Console.ReadLine(), out c);
  if (k)

    break;
  else
    Console.WriteLine("nhap sai, nhap lai");
}


var sum = a + b + c + 0.1;
sum = 5.7;
dynamic d = 5.7;
d = "xinchao";

d = @"dasjdaskjdaskdbjasjdaskjdasjkdaskj";

Console.WriteLine($"a+b+c={a + b + c}");
