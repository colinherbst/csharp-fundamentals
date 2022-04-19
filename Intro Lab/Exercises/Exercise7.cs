namespace Intro_Lab;
/* This class contains my Exercise 7 lab for Structs and Records */

/*
Change the type from class to struct. Change the name of the struct from Exercise7 to Employee.
The file name should not be changed. Create 2 struct variables. The first one will beof type int and be named _id.
The second variable should be of type stringand be named _name. Create a constructor that takes 2 arguments,
with the first being an intand the second a string. The struct variables should be assigned to the constructor 
parameters. Create properties for these 2 variables. 
*/
internal struct Employee
{
    private int _id;
    private string _name;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    { 
        get { return _name; }
        set { _name = value; }
    }
    public Employee(int id, string name)
    {
        _id = id;
        _name = name;
    } // end method

    /*
    Create a Record based on your Boat object from the Object Oriented Programming lesson.
    In your record body, include the boat method that you defined.
    This record can be in the same file as exercise 1. Just put the code under it as seen in the lecture.
    Test your record to ensure it is working correctly.
    */
    internal record Boat(string material)
    {
        public void MotorOnOff()
        {
            Console.WriteLine(material);
        }
    } // end method

} // end class

