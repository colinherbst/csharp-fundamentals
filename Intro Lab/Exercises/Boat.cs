namespace Intro_Lab;
/* This class contains my Exercise 10 lab for encapsulation */
internal class Boat
{
    /*
    Create a class based on your Boat object.
    You will follow the same instructions as exercise 1 except for the following.
    Include your attributes as Expression Body Definition Properties.
    */

    public int boatSize;
    public string boatColor;
    public string boatMaterial;

    public int BoatSize
    {
        get => boatSize;
        set => boatSize = value;
    }
    public string BoatColor
    {
        get => boatColor;
        set => boatColor = value;
    }
    public string BoatMaterial
    {
        get => boatMaterial;
        set => boatMaterial = value;
    }

    public Boat(int boatSize, string boatColor, string boatMaterial)
    {
        this.BoatSize = boatSize; 
        this.BoatColor = boatColor;
        this.BoatMaterial = boatMaterial;
    }

    public Boat(int boatSize, string boatColor)
        : this(boatSize, boatColor, "Cloth") { }

    public Boat()
        : this(3,"White") { }

    /*
    In your Boat class, add the virtual keyword to your method created in Lesson 10. 
    Create a second version of the same method and add a parameter.
    Include a Console WriteLine method in the new method that uses the parameter.
    This parameter needs to be based on one of your properties. 
    */
    public virtual void MotorOnOff()
    {
        Console.WriteLine("The boat turns on");
    }

    public void MotorOnOff(string boatColor)
    {
        Console.WriteLine($"the {boatColor} boat turns on");
    }

} // end class
