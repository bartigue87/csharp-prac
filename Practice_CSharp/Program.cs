using System;

namespace Practice_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //User me = new User();
            //me.FirstName = "Brandon";
            //me.LastName = "Artigue";

            int value = 45;

            Console.WriteLine(value.Length);
        //    decimal pricipal = 1000; //initial amount before interest
        //    double rate = 0.05; // interest rate
        
        //    //display headers
        //    Console.WriteLine("Year Amount on deposit");

        ////calculate amount on deposit for each of ten years
        //for (int year = 1; year <= 10; year++)
        //    {
        //        //calculate new amount for specified yars
        //        decimal amount = pricipal * ((decimal) Math.Pow(1.0 + rate, year));

        //        //display the year and the amount
        //        Console.WriteLine($"{year,4}{amount,20:C}");
        //    }

            



            //int passed = 0;
            //int failed = 0;
            //int gradeCounter = 1;

            //while (gradeCounter <= 10)
            //{
            //    Console.Write("Enter a 1 if passed or a 2 if failed: ");
            //    int result = int.Parse(Console.ReadLine());

            //    if (result == 1)
            //    {
            //        passed++;
            //    }
            //    else
            //    {
            //        failed++;
            //    }

            //    gradeCounter++;
            //}

            //Console.Write($"{passed} student(s) passed! ");
            //if (passed > 8)
            //{
            //    Console.WriteLine("Bonus to Instructor!");
            //}
            //Console.WriteLine($"{failed} student(s) failed!");

            
            

            //int total = 0;
            //int gradeCounter = 0;

            //Console.Write("Enter a grade or -1 to quit: ");
            //int grade = int.Parse(Console.ReadLine());

            //while (grade != -1)
            //{
            //    total = total + grade;
            //    gradeCounter++;

            //    Console.Write("Enter grade or -1 to quit: ");
            //    grade = int.Parse(Console.ReadLine());
            //}

            //if (gradeCounter != 0)
            //{
            //    double average = (double) total / gradeCounter;

            //    Console.WriteLine($"\nTotal of the {gradeCounter} grades entered is {total}");
            //    Console.WriteLine($"Class Average is {average:F}"); //:F rounds to the nearest hundreth ....so 34.458 => 34.46
            //}
            //else {
            //    Console.WriteLine("No grades were entered");
            //}



            //int total = 0;
            //int gradeCounter = 1;

            //while (gradeCounter <= 10)
            //{
            //    Console.Write("Enter grade: ");
            //    int grade = int.Parse(Console.ReadLine());
            //    total = total + grade;
            //    gradeCounter++;
            //}

            //int average = total / 10;
            //Console.WriteLine($"\nTotal of all 10 grades is { total }");
            //Console.WriteLine($"Class average is {average}");


            //Book book1 = new Book("Harry Potter", "J.K Rowling", 400);
            
            //Console.WriteLine(book1.title);


            //Console.WriteLine(GetPow(3, 6));
            //Console.ReadLine();

            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while(guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;

            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }
                
            //}
            //if (outOfGuesses)
            //{
            //    Console.Write("You Lose!");
            //}
            //else
            //{
            //    Console.Write("You Win!");
            //}
            
        }

        //static int GetPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for(int i = 0; i < powNum; i++)
        //    {
        //        result *= baseNum;
        //    }
        //    return result;
        //}
    }
}
