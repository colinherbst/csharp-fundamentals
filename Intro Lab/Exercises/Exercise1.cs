namespace Intro_Lab;
/* Exercise 1 */

public class Exercise1
{

    /*
    Write out a method with no arguments and a void return type that will
    print the output of the number 35 based on the number systems below.
    The values should be assigned to a variable inside the method prior to printing them
    using Console WriteLine. Utilize the conversion document from your resources.
    a.Decimal
    b.Hexadecimal
    c.Binary
     */
    public void Question1()
    {
        int value1 = 35; // decimal
        int value2 = 0x23; // hexadecimal
        int value3 = 0b100011; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);

    } // end method

    /*
    Write a method that will accept 3 argument parameters and a void return type.
    The first argument should be of type byte.
    The second argument should be of type short.
    The third argument should be of type int.
    Using Implicit conversion, create variables to convert to using the below information.
    Use the argument parameters as the values to convert from.
    Print each converted variable using Console WriteLine.
    a.From byte to int
    b.From short to long
    c.From int to float
     */
    public void Question2(byte MyByte, short MyShort, int MyInt)
    {
        MyByte = 3;
        MyInt = MyByte;
        Console.WriteLine(MyInt);

        MyShort = 4;
        long MyLong = MyShort;
        Console.WriteLine(MyLong);

        MyInt = 5;
        float MyFloat = MyInt;

    } //end method

    /*
    Write a method that will accept 3 argument parameters and a void return type.
    The first argument should be of type double.
    The second argument should be of type float.
    The third argument should be of type long.
    Using Explicit conversion, create variables to convert to using the below information.
    Use the argument parameters as the values to convert from.
    Print each converted variable using Console WriteLine.
    a.From double to long
    b.From float to int
    c.From long to short 
    */
    public void Question3(double MyDouble, float MyFloat, long Mylong)
    {
        MyDouble = 3;
        long MyLong = (long)MyDouble;
        Console.WriteLine(MyLong);

        MyFloat = 4;
        int MyInt = (int)MyFloat;
        Console.WriteLine(MyInt);

        MyLong = 5;
        short MyShort = (short)MyLong;
        Console.WriteLine(MyShort);

    } // end method

    /* 
    Write a method with no arguments and a void return type.
    Using the values below, assign them to a variable that best suits their value type.
    Utilize the digit separator when assigning them to your variables.
    Once you have defined your variables, print out each one using Console WriteLine.
    Do not use the same value type more than once.
    a.123456.987
    b.-9516248
    c.3500
    d.988562486
    e.-19733.14895
    */
    public void Question4()
    {
        double DoubleVal = 123456.987;
        int IntVal = -9516248;
        short ShortVal = 3500;
        long LongVal = 988562486;
        decimal DecimalVal = (decimal)-19733.14895;

        Console.WriteLine(DoubleVal);
        Console.WriteLine(IntVal);
        Console.WriteLine(ShortVal);
        Console.WriteLine(LongVal);
        Console.WriteLine(DecimalVal);
    } // end method


} // end class



