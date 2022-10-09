// See https://aka.ms/new-console-template for more information

unsafe
{
    Console.WriteLine("Hello, World!");

    int number1 = 24;
    long number2 = long.MaxValue;
    byte number3 = (byte) number2;
    byte number4 = number3;

    var n1Ptr = &number1;
    var n2Ptr = &number2;
    var n3Ptr = &number3;
    var n4Ptr = &number4;

    *n3Ptr = 4;

    int? number5 = 124;
    int? number6 = number5;
    number5 = 34;
}