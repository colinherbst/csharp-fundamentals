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

} // end class
