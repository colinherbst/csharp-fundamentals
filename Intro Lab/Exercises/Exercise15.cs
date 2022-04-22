namespace Intro_Lab;
/* This class contains my Exercise 15 lab for Enums and Tuples  */

/*
Above the class, write an enum called Favorite Movies. Add your own favorite movies to the enum.
Write a method that hasa string return type and an enum parameter.
This enum parameter will be your favorite movie enum.
Write a switch expression that takes the enum and prints out a string return.
Use string interpolation in your return message that includes the name of the movie chosen. 
*/

public enum FavoriteMovies { Real_Steal, The_Batman, Karate_Kid }
internal class Exercise15
{
    public string MyMovies(FavoriteMovies MovieName)
    {
        string movie = MovieName switch
        {
            FavoriteMovies.Real_Steal => $"One of my favorite movies is {FavoriteMovies.Real_Steal}",
            FavoriteMovies.The_Batman => $"One of my favorite movies is {FavoriteMovies.The_Batman}",
            _ => $"One of my favorite movies is {FavoriteMovies.Karate_Kid}"

        };
        return movie;

    } // end method

    /*
    Write a method that takes an enum parameter. This enum will be your favorite movie enum.
    The method will have a tuple return type(intnum, stringmovie). Using an explicit int cast
    on one of your enum, assign the value to an int variable. Create second variable of type string.
    Assign the same enum value you used and use the ToString() at the end of it. 
    Return both variables as a tuple. See examplebelow for clarity.
    a.Int value = (int)Enum.Value;
    b.string something = Enum.Value.ToString();
    */
    public (int num, string movie) Movies(FavoriteMovies movie)
    {
        int value = (int) movie;
        string name = movie.ToString();
        return (value, name);

    } // end method

} // end class
