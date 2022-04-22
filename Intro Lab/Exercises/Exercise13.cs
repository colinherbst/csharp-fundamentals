namespace Intro_Lab;
/* This class contains my Exercise 13 lab for abstract & interfaces  */

/*
In your Exercise13.cs file, change your class to an Interface and name it IMovement.
This interface will have 1 property. The property will an int and called Speed.
will have a get and init. 
*/
internal interface IMovement
{
    int Speed { get; init; }

} // end interface

/*
Under the interface you will create an Abstract class called WaterBirds.
This abstract class will implement the IMovement interface.
The interface property should be implemented in the Abstract class as an abstract property.
Create two abstract methods for the abstract class that is related to WaterBirds.
Create a constructor that will take an int parameter and be assigned to the Speed property.
*/
internal abstract class WaterBirds : IMovement
{
    public abstract int Speed { get; init; }

    public abstract void Swim();
    public abstract void Fly();

    public WaterBirds(int speed)
    {
        this.Speed = speed;
    }

} // end class

/*
Under the Abstract class Waterbirds, create a derived class that will extend the WaterBird class.
Implement the abstract methods and property. Use Console Writeline statements in your methods
that provide information related to the methods. One of them should use an Interpolation string
and consume the Speed property. Create a constructor that will take an int parameter
and use the :base()to pass that int value back to the base Abstract class.
*/
internal class Duck : WaterBirds
{
    public override int Speed { get; init; } = 3;

    public override void Swim()
    {
        Console.WriteLine($"The duck swims away at {Speed} miles per hour");
    }

    public override void Fly()
    {
        Console.WriteLine($"The bird starts to fly");
    }

    public Duck(int speed)
        : base(speed) { }

} // end class