
namespace Intro_Lab;

/*
 This class goes over value types.
 */ 
internal class Lesson1
{
    // Integral Signed

    // sbyte range -128 to 127

    sbyte mySByte = 2;
    public void SByteMinMax()
    {
        Console.WriteLine(Int16.MinValue);
        Console.WriteLine(Int16.MaxValue);
    }

    // short range -32, 768 to 32,767
    short myShort = 6;

    public void ShortMinMax()
    {
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
    }

    // int range -2,147,483,648 to 2,147,483,647
    int myInt = 25685;
    public void IntMinMax()
    {
        Console.WriteLine(Int32.MinValue);
        Console.WriteLine(Int32.MaxValue);    
    }

    // long range -9,223,327,036,854,775,808 to
    // 9,223,327,036,854,775,807
    long myLong = 123456789L;

    public void LongMinMax()
    {
        Console.WriteLine(Int64.MinValue);
        Console.WriteLine(Int64.MaxValue);
    }

}
