namespace Intro_Lab;
/* This class contains my Exercise 14 lab for arrays  */
internal class Exercise14
{
    /*
    Write a method with no parameters and no return type. Write a single dimensional string array of ice cream flavors.
    Using a foreach loop in your method, print out the results of your array using a Console WriteLine statement.
    */
    public void IceCreamFlavors()
    {
        string[] flavors = { "chocolate", "vanilla", "strawberry", "rasberry" };

        foreach(string flavor in flavors)
        {
            Console.WriteLine(flavor);
        }
    } // end method

    /*
    Write a method with no parameters and no return type. Write a two-dimensional array using the int data type.
    Using the link below, fill in each dimension with the KC Chiefs Regular season scores.
    The first dimension will be the home team, while the second dimension will be the away team.
    Using a foreach loop, print out the results of your array using a Console WriteLine statement. 
    To determine which team is home and away, the website includes the link to the box score.
    The link label shows both teams. The first team in the label is the away team.
    
    a.https://www.footballdb.com/teams/nfl/kansas-city-chiefs/results/2020
    */
    public void CheifsScores()
    {
        int[,] scores = { { 34, 23, 34, 26, 32, 26, 43, 35 }, { 20, 20, 20, 10, 40, 17, 16,9 } };

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

    } // end method

} // end class