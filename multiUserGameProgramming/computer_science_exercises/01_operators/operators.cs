// Julian Guevara, Program Template, V0.2
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
           // Create TWO Strings, Integer, and Float variables.
           string string1 = "mmm apple.";
           string string2 = "mmm cheeseburger.";

           int myInt1 = 28;
           int myInt2 = 29;

           float myFloat1 = 0.02f;
           float myFloat2 = 0.03f;

           // Arithmetic Operators
           Console.WriteLine(myInt1 + myInt2);
            Console.WriteLine(string1 + string2);
            Console.WriteLine(myFloat1 + myFloat2);
            Console.WriteLine(myInt1 + myFloat2);

            Console.WriteLine(myInt1 / myInt2);
            // Console.WriteLine(string1 / string2); cannot be applied to operands of type `string' and `string'
            Console.WriteLine(myFloat1 / myFloat2);
            Console.WriteLine(myInt1 / myFloat2);

            Console.WriteLine(myInt1 - myInt2);
            // Console.WriteLine(string1 - string2);  cannot be applied to operands of type `string' and `string'
            Console.WriteLine(myFloat1 - myFloat2);
            Console.WriteLine(myInt1 - myFloat2);

            Console.WriteLine(myInt1 * myInt2);
            // Console.WriteLine(string1 * string2);  cannot be applied to operands of type `string' and `string'
            Console.WriteLine(myFloat1 * myFloat2);
            Console.WriteLine(myInt1 * myFloat2);

            // Modulus
            Console.WriteLine("Modulus");
            Console.WriteLine(10 % 2)
            Console.WriteLine(9 % 4)

            // Increment
            int myInt3 = 1;
            myInt2++;
            Console.WriteLine(myInt3);

            // DECREMENT
            int myInt4 = 1;
            myInt2--;
            console.WriteLine(myInt4);

            // Asignment Operators
            // =
            // +=
            // -=
            // *=
            // /=

            // Comparison Operators
            // Is Equal To
            // Greater Than
            // Greater Than or Equal To
            //Less Than
            //Less than or Equal To
            // Not Equal To

            // Logical Operators
            // And
            // Or
            // Not
        }
    }
}
 