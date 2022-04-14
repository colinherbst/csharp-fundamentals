namespace Intro_Lab;

public class Exercise4
{

    /*
    Write amethod that takes 2 string argumentsand a void return type.
    Using and if-else statement, compare the two strings to each other.
    Using a Console WriteLine statement, print out the results of whether the strings are equal.
    Provide a comment inside the method that says what strings you used during testing.
    */
    public void Question1(string arg1, string arg2)
    {
        if (arg1 == arg2)
        {
            Console.WriteLine($"{arg1} is the same as {arg2}");
        }
        else
        {
            Console.WriteLine($"{arg1} is not the same as {arg2}");
        }
        /*
        when arg1 is set as "test1" and arg2 is set as "test2" then "test1 is not the same as test2" is printed

        when arg1 is set as "test1 and arg2 is set as "test1" then "test1 is the same as test1" is printed
        */
    } //end method

    /*
    Write a method that will take 1 char argumentand a string return type.
    Using a switch and the table below, return the description.
    If the value does not match the grade, return the default message, “Not a valid grade”.
    E = Exellent
    V = Very Good
    G = Good
    A = Average
    F = Fail
    */
    public string Question2(char arg)
    {
        switch(arg)
        {
            case 'E':
                return ("Exellent");
            case 'V':
                return ("Very Good");
            case 'G':
                return ("Good");
            case 'A':
                return ("Average");
            case 'F':
                return ("Fail");
            default:
                return ("Not a valid grade");
                
        }
    } // end method

    /*
    Write a method that takes no argumentsand a void return type.
    Using an iteration statement, display all the numbers divisible by 3 from 0 to 30.
    Utilize a modulus to obtain your results.
    */
    public void Question3()
    {
        for (int i = 0; i < 31; i++)
        {
            if ((i % 3) == 0)
            {
                Console.WriteLine(i);
            }
        }
    } // end method

} // end class
