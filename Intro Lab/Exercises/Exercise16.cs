namespace Intro_Lab;
/* This class contains my Exercise 16 lab for Collections */
internal class Exercise16
{
    /*
    Write a method that has no parameters and a no return type. 
    Create a List<T> of your Horse objects. When creating your list,
    utilize all the constructors you created with your Horse class.
    Using a foreach loop, printout the results of your collection
    using a Console WriteLine statement. 
    */
    public void HorseAttributes()
    {
        List<Horse> horseAttributes = new List<Horse>();
        horseAttributes.Add(new Horse());
        horseAttributes.Add(new Horse("White", 3, 850));
        horseAttributes.Add(new Horse("Brown", 4, 900));

        foreach (Horse horse in horseAttributes)
        {
            Console.WriteLine(horse.HorseColor);
            Console.WriteLine(horse.HairLength);
            Console.WriteLine(horse.HorseWeight);
        }

    } // end method

    /*
    Write a method that has no parameters and noreturn type. 
    Using only the data you used when building your favorite movies from exercise 15,
    create a Dictionary collection that takes an int key and string value. 
    When adding Dictionary elements, pick an int value as the key and use the favorite movies data as thestring.
    Using a foreach loop, print out the results of your collection using a Console WriteLine statement.
    */
    public void MovieDictionary()
    {
        Dictionary<int, string> movieDictionary = new Dictionary<int, string>();
        movieDictionary.Add(1, "Real Steel");
        movieDictionary.Add(2, "The Batman");
        movieDictionary.Add(3, "Karate Kid");

        foreach(KeyValuePair<int, string> movie in movieDictionary)
        {
            Console.WriteLine($"Movie {movie.Key} is {movie.Value}");
        }

    } // end method
    
} // end class
