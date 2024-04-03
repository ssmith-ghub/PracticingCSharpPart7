using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;

            //friends = friends + 1; // standard way how to increase variable friends because we all make new friends
            //friends += 2; // shortcut or another way of doing the above adding of new friends to variable "friends" 
            //friends++; // this way is found within loops most commonly and only does increments of 1 when increasing the variable

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2; //because friends is an int variable type we cant get a deciaml number so it defaults to a whole number when divied.
            //friends /= 2;

            int remainder = friends % 3; //remainder operator

            Console.WriteLine(friends);
            Console.ReadLine();
            Console.WriteLine(remainder);
            Console.ReadKey();
            Console.Beep();
        }
    }
}
