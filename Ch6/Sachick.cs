﻿using System;
using Ch6_dll;

public class Ch6_2
{
    public static void Main()
    {
        float aa = 0;
        float bb = 0;

        Console.Write("하나의 수를 입력하세요 : ");
        aa = Convert.ToSingle(Console.ReadLine());
        Console.Write("또 하나의 수를 입력하세요 : ");
        bb = Convert.ToSingle(Console.ReadLine());

        float Value1 = Calc.연산.Plus(aa, bb);
        Console.WriteLine("a + b = {0}", Value1);

        float Value2 = Calc.연산.Minus(aa, bb);
        Console.WriteLine("a - b = {0}", Value2);

        float Value3 = Calc.연산.Multiply(aa, bb);
        Console.WriteLine("a * b = {0}", Value3);

        float Value4 = Calc.연산.Divide(aa, bb);
        Console.WriteLine("a / b = {0}", Value4);
    }
}