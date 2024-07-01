namespace Assignment
{
    internal class Program 
   
    {
        #region Question1
        //static void SWAP(int x, int y)
        //{
        //    int tem = x;
        //    x = y;
        //    y = tem;
        //}
        static void SWAP(ref int x,ref int y)
        {
            int tem = x;
            x = y;
            y = tem;
        }
        #endregion


        #region Question2
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
        }
    }
}
