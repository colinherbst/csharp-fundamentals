namespace Intro_Lab;
/* This class contains my Exercise 11 lab for inheritance */
internal class Mustang : Horse
{
    /*
    Create a child class based on your Horse object. Include onechild attribute asanauto property.
    Create 3 constructors. The first constructor should have 4 parameters with 3 of them from
    Horse and your child property. Using the keyword :base(), you will put the four
    horse parameters in the parenthesis. In the body of the constructor you will
    assign your child parameter to your property. The second constructor should have 2parameters,
    2 based on the horse and 1 from your child. Using the :this()keyword, you will pass 2
    of the parent attributes and your child attributeinformation to the first constructor. 
    Include default values to represent the 2 remaining horse parameters. For the last constructor,
    you will create the default constructor. Using the :this()keyword, you will pass 2 default
    values in that will pass to the 2nd constructor. Also include in the class, your method for your child class.
    */
    public int TailLength { get; set; }

    public Mustang(string horseColor, int noseLength, int HorseWeight, int tailLength)
        : base(horseColor, tailLength, noseLength)
    {
        TailLength = tailLength;
    }

    public Mustang(string horseColor, int noseLength, int tailLength)
        :this(horseColor, noseLength, 3, tailLength) { }

    public Mustang()
        :this("Black", 3, 4) { }

    public void Wild()
    {
        Console.WriteLine("The mustang is wild");
    }

} // end class
