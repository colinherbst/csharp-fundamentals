namespace Intro_Lab;
/* Exercise 2 */

public class Exercise2
{

    /* 
    Write a method that takes a string argument parameter and void return type.
    Using string concatenation and the below string methods,
    write a Console WriteLine statement for each of them.
    Inside the string concatenation will be the name of each string method.
    When testing this method use the followingstring “EXERCISE two Lab “.
    Do not copy and paste this in Visual Studio. It will not paste correctly.
    a.Trim()
    b.ToLower()
    c.Contains(“two”)
    d.Length()
    e.IndexOf(‘C’)
     */
    public void Question1(string value)
    {
        Console.WriteLine("Trim() " + value.Trim());
        Console.WriteLine("ToLower() " + value.ToLower());
        Console.WriteLine("Contains() " + value.Contains("two"));
        Console.WriteLine("Length " + value.Length);
        Console.WriteLine("IndexOf('C') " + value.IndexOf('C'));
    } // end method

    /*
    Write a method that takes no arguments and a void return type.
    Using the Unicode table resource link, assign the Unicode value of the Pilcrow Sign to a variable.
    Use the Console WriteLine to print that variable. 
    This variable should utilize the type that takes 1 character.
    */
    public void Question2()
    {
        char PilcrowSign = '\u00b6';
        Console.WriteLine(PilcrowSign);
    } // end method

    /*
    Write a method that takes no arguments and a void return type.
    Use 1 string variable and 1 Console WriteLine to complete this task.
    Use escape sequences to achieve the below results.

    Output:
    Jack and Jill
    went up the hill
    to fetch a pail of water.
    Jack fell down and broke his crown
    and Jill came tumbling after.
    */
    public void Question3()
    {
        string JackJill = "Jack and Jill \nwent up the hill \nto fetch a pail of water." +
            "\nJack fell down and broke his crown \nand Jill came tumbling after";
        Console.WriteLine(JackJill);
    } // end method

    /*
    Write a method that takes no arguments but does have a string return type.
    You will utilize Interpolation to complete this task.
    Create variables for each provided data below.
    Using Interpolation return a string that includes the variables in a sentence.
    a.Name
    b.Favorite movie
    c.Favorite movie snack
    d.Favorite movie drink
    */
    public string Question4()
    {
        string Name = "Colin";
        string FavoriteMovie = "Batman";
        string FavoriteSnack = "Popcorn";
        string FavoriteDrink = "Lemonade";
        return $"My name is {Name}, my favorite movie is {FavoriteMovie}, " +
            $"at the movies I like to eat {FavoriteSnack} while drinking {FavoriteDrink}";
    } // end method

} // end class