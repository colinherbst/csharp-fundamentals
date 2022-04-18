namespace Intro_Lab;
/* This class contains my Exercise 6 lab for Constructors and Methods */
public class Exercise6
{
    /*
    Write a constructor for your exercise file that takes 2 parameters.
    The first parameter should have an int type and a variable name of showSize.
    The second parameter should have a string type and a variable name of shoeType.
    Create private class variables for these types and use and under score when defining them.
    Inside the constructor associate the class variables with the constructor parameters. 
    */

    private int _shoeSize;
    private string _shoeType;

    public Exercise6(int size, string type)
    {
        _shoeSize = size;
        _shoeType = type;
    } // end method

    /*
    Write the properties for the class variables defined in exercise 1.
    Ensure they are labeled as public and are spelled using a capital letter. 
    */
    public int ShoeSize
    {
        get { return _shoeSize; }
        set { _shoeSize = value; }
    }
    
    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    } // end method

    /*
    Write a delegate that takes a string parameter. This delegate should be named TryOn.
    Write a method that takes a string argument and void return type.
    In the method body include a Console WriteLine statement that will print the message.
    Test your delegate in Program.cs to ensure everything works properly. 
    Using a mult-line comment on your Exercise6.cs file,
    provide the information you used to test the delegate.
    */
    public delegate void TryOn(string type);
    public void TryShoe(string message)
    {
        Console.WriteLine(message);
    } //end method
    /*
    void Exercise6()
    {
        Exercise6 myShoes = new Exercise6(10, "Nike");
        Exercise6.TryOn theShoe = myShoes.TryShoe;
        theShoe($"I tried on a size {myShoes.ShoeSize} {myShoes.ShoeType} shoe");
    }
    Exercise6();
    */

} // end class
