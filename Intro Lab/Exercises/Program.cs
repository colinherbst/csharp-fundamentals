using Intro_Lab;

// Exercise 3 Test
void Exercise3()
{
    Exercise3 myExercise3 = new Exercise3();
    Console.WriteLine(myExercise3.Question1(2));
    myExercise3.Question2();
    myExercise3.Question3(10, 100);
    myExercise3.Question4(false, true);
}
Exercise3();

// Exercise 4 Test
void Exercise4()
{
    Exercise4 myExercise4 = new Exercise4();
    myExercise4.Question1("test1", "test2");
    Console.WriteLine(myExercise4.Question2('W'));
    myExercise4.Question3();
}
Exercise4();

// Exercise 5 Test
void Exercise5()
{
    Exercise5 myExercise5 = new Exercise5();
    Console.WriteLine(myExercise5.Question1(14, 28));
    Console.WriteLine(myExercise5.Question2('A'));
    myExercise5.Question3(16);
}
Exercise5();

//Exercise 6 Test
void Exercise6()
{
    Exercise6 myShoes = new Exercise6(10, "Nike");
    Exercise6.TryOn theShoe = myShoes.TryShoe;
    theShoe($"I tried on a size {myShoes.ShoeSize} {myShoes.ShoeType} shoe");
}
Exercise6();

//Exercise 7 test
void Exercise8Test()
{
    Exercise8.LengthWidthCalc(5, 3);
}
Exercise8Test();