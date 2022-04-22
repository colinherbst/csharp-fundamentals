namespace Intro_Lab;
/* This class contains my Exercise 11 lab for inheritance */
internal class Yacht : Boat
{
    /*
    Create a child class based on your Boat object.
    You will follow the same instructions as exercise 1 except for the following.
    Include 1 child attribute as Expression Body Definition Properties. 
    */

    public int roomAmount;
    
    public int RoomAmount
    {
        get => roomAmount;
        set => roomAmount = value;
    }

    public Yacht(int boatSize, string boatColor, string boatMaterial, int roomAmount)
        : base(boatSize, boatColor, boatMaterial)
    {
        this.roomAmount = roomAmount;
    }

    public Yacht(int boatSize, string boatColor, int roomAmount)
        :this(boatSize, boatColor, "White", roomAmount) { }

    public Yacht()
        :this(4, "Black", 30) { }

    public void RoomBooked()
    {
        Console.WriteLine("The Room is booked");
    }
}
