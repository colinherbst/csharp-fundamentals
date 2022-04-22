namespace Intro_Lab;
/* This class contains my Exercise 10 lab for encapsulation */
internal class Horse
{
    /*
    Create a class based on your Horse object. Include your attributes as auto properties.
    Create 3 constructors. The first constructor should have parameters equal to your properties.
    Assign each parameter to your properties. The second constructor should have 2 parameters.
    Using the :this() keyword, you will pass your information to the first constructor. 
    This includes the 2 parameters and default values. For the last constructor,
    you will create the default constructor. Using the :this()keyword, you will pass 2 default
    values in that will pass to the 2nd constructor. Also include in the class, your method for Horse. 
    */

    public string HorseColor { get; init; }
    public int HairLength { get; init; }
    public int HorseWeight { get; init; }

    public Horse(string horseColor, int hairLength, int horseWeight)
    {
        HorseColor = horseColor;
        HairLength = hairLength;
        HorseWeight = horseWeight;
    }
    public Horse(string horseColor, int hairLength)
        :this(horseColor, 1 , hairLength) { }

    public Horse()
        :this("Black", 3) { }

    public virtual void WakeUp()
    {
        Console.WriteLine("The horse wakes up");
    }
}

