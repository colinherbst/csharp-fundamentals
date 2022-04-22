namespace Intro_Lab;
/* This class contains my Exercise 10 lab for encapsulation and my Exercise 12 lab for Polymorphism */
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

    } // end class

    /*
    In your Horse class, add the virtual keyword to your method created in Lesson 10.
    Create a second version of the same method and add a parameter.
    Include a Console WriteLine method in the new method that uses the parameter. 
    This parameter needs to be based on one of your properties. 
    */

    public void WakeUp(string horseColor)
    {
        Console.WriteLine($"The {horseColor} horse wakes up.");
    }
} // end class

