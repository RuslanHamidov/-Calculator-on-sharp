using System;

Console.WriteLine("Enter first number: ");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
float b = float.Parse(Console.ReadLine());


Console.WriteLine("Select operation:\n1.Sum(sum)\n2.Extraction(ex)\n3.Multiplying(mult)\n4.Division(div)\n");
string operation = (Console.ReadLine());

if (operation == "sum")
{

    Console.WriteLine(a + b);
}

if (operation == "ex")
{

    Console.WriteLine(a - b);
}


if (operation == "mult")
{

    Console.WriteLine(a * b);
}

if (operation == "div")
{

    Console.WriteLine(a / b);
}
