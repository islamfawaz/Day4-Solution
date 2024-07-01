using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program

    {
        #region Question1

        // Passing by Value  When a value type parameter is passed by value,
        // a copy of the actual value is passed to the function.
        // This means that any changes made to the parameter inside the function
        // do not affect the original value outside the function.

        //Passing by Reference
        // When a value type parameter is passed by reference,
        // a reference to the actual memory location of the value is passed to the function.
        // This means that any changes made to the parameter inside the function
        // do affect the original value outside the function


        //static void SWAP(int x, int y)
        //{
        //    int tem = x;
        //    x = y;
        //    y = tem;
        //}
        //static void SWAP(ref int x,ref int y)
        //{
        //    int tem = x;
        //    x = y;
        //    y = tem;
        //}
        #endregion


        #region Question2
        // Passing Reference Type Parameters by Value
        //  When a reference type parameter is passed by value, a copy of the reference(not the object itself)
        //  is passed to the method.This means that while the method cannot change the reference itself
        //  to point to a new object, it can modify the object that the reference points to.


        //Passing Reference Type Parameters by Value
        //When a reference type parameter is passed by value, a copy of the reference(not the object itself)
        //is passed to the method.This means that while the method cannot change the reference itself to point
        //to a new object, it can modify the object that the reference points to.



        //static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;

        //}

        //static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;

        //}
        #endregion

        #region Question3
        //static void SumSubtract(int num1,int num2,out int summation ,out int subtraction)
        //{
        //    summation = num1+num2;
        //    subtraction = num1 - num2;
        //}
        #endregion

        #region Question4
        //static int SumDigit(int num)
        // {
        //     int sum = 0;
        //     while (num is not 0)
        //     {
        //        sum+= num % 10;
        //         num /= 10;

        //     }
        //     return sum; 
        // }
        #endregion

        #region Question5
        //use the Sieve of Eratosthenes
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    if (number <= 3) return true;

        //    if (number % 2 == 0 || number % 3 == 0) return false;

        //    int sqrt = (int)Math.Sqrt(number);
        //    bool[] sieve = new bool[sqrt + 1];
        //    for (int i = 2; i <= sqrt; i++)
        //    {
        //        sieve[i] = true;
        //    }
        //    for (int i = 2; i * i <= sqrt; i++)
        //    {
        //        if (sieve[i])
        //        {
        //            for (int j = i * i; j <= sqrt; j += i)
        //            {
        //                sieve[j] = false;
        //            }
        //        }
        //    }

        //    for (int i = 2; i <= sqrt; i++)
        //    {
        //        if (sieve[i] && number % i == 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        #endregion

        #region Question6
        //6 Create a function named MinMaxArray, to return the minimum and maximum values
        //stored in an array, using reference parameters
        //static void MinMaxArray(  out int max, out int min , params int[] arr)
        //{
        //    max = arr[0];
        //    min = arr[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {

        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }

        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //    }
        //}


        #endregion

        #region Question7
        //static long Factorial(int num)
        //{
        //    long result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        #endregion

        #region Question8
        static string ChangeChar(string str, int index, char newChar)
        {
            if (index >= str.Length  || index < 0)
            {
                return str;
            }

            char[] charArr = str.ToCharArray();
            charArr[index] = newChar;
            return new string(charArr);
        }
    
    #endregion

    static void Main(string[] args)
            {
            #region Question1
            //1 Explain the difference between passing (Value type parameters) by
            //value and by reference then write a suitable c# example.
            //int A = 3,B=5;
            //SWAP(A,B);
            //Console.WriteLine("After swap passing by value");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B= {B}");

            //int A = 3, B = 5;
            //SWAP(ref A, ref B);
            //Console.WriteLine("After swap passing by ref");
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B= {B}");




            #endregion

            #region Question2
            //2 Explain the difference between passing (Reference type parameters)
            //by value and by reference then write a suitable c# example.

            //int [] num = {1,2,3};
            //int total = SumArray(num);
            //Console.WriteLine(total);

            //int[] num = { 1, 2, 3 };
            //int total = SumArray(ref num);
            //Console.WriteLine(total);

            #endregion

            #region Question3
            //3 Write a c# Function that accept 4 parameters from user
            //and return result of summation and subtracting of two numbers
            //int num1,num2;
            //num1=int.Parse(Console.ReadLine());
            //num2=int.Parse(Console.ReadLine());

            //SumSubtract(num1, num2, out int summation, out int subtraction);
            //Console.WriteLine("Summation: " + summation);
            //  Console.WriteLine("Subtraction: " + subtraction);
            #endregion

            #region Question4
            //4 Write a program in C# Sharp to create a function
            //to calculate the sum of the individual digits of a given number.

            //int n;
            //n=int.Parse( Console.ReadLine());
            //Console.WriteLine(SumDigit(n));
            #endregion

            #region Question5
            //5 Create a function named "IsPrime", which receives an integer number and
            //retuns true if it is prime, or false if it is not:
            //int num;
            //num=int.Parse(Console.ReadLine());
            //bool res= IsPrime(num);
            //Console.WriteLine(res);
            #endregion

            #region Question6
            //int min, max;
            //MinMaxArray(out max,out min, 1,2,3,4,5);
            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");


            #endregion

            #region Question7
            //7 Create an iterative (non-recursive) function to calculate the factorial of the number specified
            //as parameter

            //int num;
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Factorial(num));



            #endregion

            #region Question8
            //8 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string,
            //replacing it with a different letter
            string oldString = "illam";
            int position = 1;
            char newChar = 's';

            string modString = ChangeChar(oldString, position,newChar);
            Console.WriteLine($"Original string: {oldString}");
            Console.WriteLine($"Modified string: {modString}");
            #endregion
        }
    }
    }

