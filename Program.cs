// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.ComponentModel;


    public class NormalTest3
    {

    }
public class Testing 
{

        public void pyramid()
    {
        int row = 8;
        int space = row;
        int len = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < space - 1; j++)
            {
                Console.Write(" ");
            }
            space = space - 1;

            for (int k = 0; k <= len; k++)
            {
                Console.Write("*");
            }

            len = len + 2;

            Console.WriteLine();
        }
    }


    public void recursion()
    {
        int value = 5;
        int p1 = 1;

        int val = TestRecon();
        Console.Write(val);

        int TestRecon()
        {
            for (int i = 1; i <= value; i++)
            {
                p1 = p1 * i;
            }
            return p1;
        }
    }

    //void BubbleSort()
    //{
    //    int[] value = { 10, 2, 5, 3, 4,6,8,7,9,1 };
    //    int p1 = 1;
    //    int temp = 0; 
    //        for (int i = 0; i < value.Length; i++)
    //        {
    //            for (int j = 0; j < value.Length-1; j++)
    //            {
    //                if (value[j] > value[j+1])
    //                {
    //                    temp = value[j];
    //                    value[j] = value[j + 1];
    //                    value[j + 1] = temp;
    //                }
    //            }
    //        }
    //    foreach (var item in value)
    //    { 
    //        Console.Write(item +",");
    //    }

    //}


    public void outtest(int num1, int num2, out int add, out int sub)
    {
        add = num1+ num2;
        sub = num1 - num2;
    }

    public void testrpos()
    {
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int n = alpha.Length;
        int len = 0;
        int space = n / 2;

        for (int i = 0; i < n; i++) 
        {
            //Console.WriteLine(alpha.Substring(0, i));
            if (n/2 > i)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (len == n)
                    {
                        len = 0;
                    }

                    Console.Write(alpha[len]);
                    len = len + 1;
                }
                Console.WriteLine();
            }
            else 
            {
                for (int j = space; j > 0; j--)
                {
                    if (space == n)
                    {
                        len = 0;
                    }
                    Console.Write(alpha[len]);
                    len = len + 1;
                }
                Console.WriteLine();
                space = space -1;
            }
           

        }
       
    }

 


    //public virtual int funtest(int a)
    //{ 
    //  return a = a + 10;
    //}

    //void ABC()
    //{
    //    char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    //    int height = alpha.Length;

    //    int len = 0;
    //    int space = height/2;

    //    for (int i = 0; i < height; i++)
    //    {
    //        if (i < height / 2)
    //        {

    //            for (int j = 0; j < i+1; j++)
    //            {
    //                if (len == height)
    //                {
    //                    len = 0;
    //                }
    //                Console.Write(alpha[len]);
    //                len = len + 1;
    //            }

    //            Console.WriteLine();
    //        }
    //        else 
    //        {
    //            for (int k = 0; k < space; k++)
    //            {
    //                if (len == height)
    //                {
    //                    len = 0;
    //                }
    //                Console.Write(alpha[len]);
    //                len = len + 1;
    //            }
    //            space = space - 1;
    //            Console.WriteLine();
    //        }

    //    }
    //}

        public void febotest()
        {
            //int a = 1;
            int num2 = 1;
            Console.WriteLine("Please enter a length of the fibonacci");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;


            for (int i = 0; i < num; i++)
            {
            if (i == 0)
            {
                Console.Write(a + " ");
            }
            else if (i == 1)
            {
                Console.Write(b + " ");
            }
            else {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
           
            }    
        }


    //Palindrome
    //public void palidrome()
    //{
    //    Console.WriteLine("enter a Palindrome");
    //    string num = Console.ReadLine();
    //    string rev = null;
    //    for (int i = num.Length - 1; i >= 0; i--)
    //    {
    //        rev += num[i];
    //    }

    //    if (rev == num)
    //    {
    //     Console.WriteLine("string is palindrome");
    //    }
    //    else 
    //    {
    //        Console.WriteLine("string is not palindrome");
    //    }
    //}
}

public class mainprog2
{
    public static void Main(string[] args)
    {
        Testing ty = new Testing();

        int[] num = { 3, 9, 7, 3 };
        //int[] num2 = new int[4];
        //out num2;

        //int i = 27;
        //Console.WriteLine("Previous value of integer i:" + i.ToString());
        //string test = GetNextNameByOut(ref i);
        //Console.WriteLine("Current value of integer i:" + i.ToString());

        //static string GetNextNameByOut(ref int id)
        //{
        //    id = 20;
        //    string returnText = "Next-" + id.ToString();
        //    return returnText;
        //}

        //int[] va = addsum(num, 9);
        //Console.WriteLine("{0} , {1}" , va[0],va[1]);
        //long x = Facto(5);

        //halfDiamond();
        //Diamond();
        //NumberTriangle(5);
        //NumberDiamond(6);
        //evenlyDivides(12);

        //countallDigit(12);
        //findLastDigit();
        //oddOrEven();
        //reviseNumber();
        //reverseNumberArrary(num);
        //double val = FindPowerOfNumber(4,10000);
        //int val = GCD(60, 36);  //Greatest of Common Divisor
        //FindAllDivisorOfNumber(24);
        //bool val = isPrimeorNot(35);
        //PrimeorNot();
        //perfectNumber(36);
        //LargestNumberinArray(1,2,3,4,5);
        //Console.WriteLine(val);
        //SecondLargestNumber(1,5,9,2,6,1,0);
        //SecondSmallestNumber(1,5,9,2,6,1,0);
        //RemoveDuplicate(1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 7, 7, 7);
        //printTables(9);
        //numberofDigits(15643);
        //armstrongNumber(153);
        //ReverseEquation("2*5/3-1+70");
        //print_divisors(36);



        //************************************************//   Practice problems    //*************************************************************

        //halfDiamond
        static void halfDiamond()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n * 2; i++)
            {
                int val = i > n ? 2 * n - i : i;

                for (int j = 0; j < val; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        //Diamond
        static void Diamond()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n * 2; i++)
            {
                int val = i > n ? 2 * n - i : i;
                int spaces = n - val;
                for (int k = 0; k < spaces; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < val; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void NumberTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int space = 0; space < n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void NumberDiamond(int n)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                int val = i > n ? 2 * n - i : i;

                for (int space = 0; space < n - val; space++)
                {
                    Console.Write(" ");
                }
                for (int j = val; j >= 1; j--)
                {
                    Console.Write(j);
                }
                for (int j = 2; j <= val; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void PrimeorNot()
        {

            int val = 15;
            int n = (int)Math.Sqrt(val);

            int n1 = (int)Math.Min(1, val);

            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (val % i == 0)
                {
                    count++;

                    if (val * i != i)
                    {
                        count++;
                    }
                }
            }
            if (count > 2 || count == 1)
            {
                Console.WriteLine("Number is Not Prime");
            }
            else
            {
                Console.WriteLine("Number is Prime");
            }
        }

        //Factorial

        static long Facto(int X)
        {
            if (X == 0)
            {
                return 1;
            }
            else
            {
                long x = X * Facto(X - 1);
                return x;
            }
        }

        static void reverseNumberArrary(int[] arr)
        {
            for (int i = arr.Length; i >= 0; i--)
            {
                //num2[0] = arr[i - 1];
            }
        }

        //static void evenlyDivides(int N)
        //{
        //    string a = N.ToString();
        //    int count = 0;
        //    foreach (var i in a)
        //    {
        //        if ((int)i == 0)
        //        {
        //            continue;
        //        }
        //        else if (N % (int)i == 0)
        //        {
        //            count += 1;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}

        //**************************************//   DSA code sheet preparation solutions    //****************************************************

        //evenlyDivides
        static int evenlyDivides(int N)
        {
            int temp = N, count = 0;
            while (temp != 0)
            {
                // extract the last digit
                int d = temp % 10;
                temp = temp / 10;

                // check if d divides N completely and is not zero
                if (d > 0 && N % d == 0)
                    count++;
            }
            return count;
        }

        static void ReverseEquation(string s)
        {
            //"2*5/3-1+70"
            Stack<string> stk = new Stack<string>();
            string current = "";
            foreach (char c in s)
            {
                //if (char.IsLetterOrDigit(c))
                //{
                    current += c;
                    stk.Push(current);
                current = "";
                //current += c;
                //}
                //else
                //{
                //    if (!string.IsNullOrEmpty(current))
                //    {
                //        stk.Push(current);
                //        current = "";
                //    }
                //    stk.Push(c.ToString());
                //}
            }
            //if (!string.IsNullOrEmpty(current))
            //{
            //    stk.Push(current);
            //}
             Console.WriteLine(string.Concat(stk.ToArray()));
        }


        static void printTables(int n) 
        { 
            List<int> dt = new List<int>();
            for (int i = 1; i <= 10; i++) { 
              dt.Add(i*n);
            }
            foreach (int i in dt)
            {
                Console.Write(i+",");
            }
            dt.Sort();
        }

        static void numberofDigits(int a)
        {
            int n = 0;

            while (a > 0) {
                n++;
                a=a/10;
            }
            Console.WriteLine(n);
        }

        static void armstrongNumber(int n)
        {
            int rem = 0;
            int sum = 0;
            int temp = n;
            int digit = 0;

            while (temp > 0)
            {
                temp = temp / 10;
                digit++;
            }
            temp = n;

            while (temp > 0)
            {
                rem = temp % 10;
                sum = sum + (int)Math.Pow(rem, digit);
              temp = temp / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static void print_divisors(int n)
        {
            List<int> val = new List<int>();

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    val.Add(i);
                    if (n / i != i)
                    {
                        val.Add(n / i);
                    }
                }
            }
            val.Sort();
            foreach (int r in val)
            {
                Console.Write(r + " ");
            }
        }

        //findLastDegit
        static void findLastDigit()
            {

                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());
                int Last = 0;
                Last = n % 10;
                Console.WriteLine("The Last digits of the number is " + Last);
            }

            //oddOrEven
            static void oddOrEven()
            {
                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());


                if (n % 2 == 0)
                    Console.WriteLine("The number is even");

                else
                    Console.WriteLine("The number is odd");
            }

            static void reviseNumber()
            {

                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());
                int rem = 0;
                int rev = 0;
                string val = "";
                while (n > 0)
                {
                
                    rem = n % 10;
                    n = n / 10;
                    //val += rem;
                    rev = rev * 10 + rem;
                }
                Console.WriteLine("The revised value is " + rev);
                Console.ReadKey();
            }

            static double FindPowerOfNumber(double x, int n)
            {
                double ans = 1.0;
                long nn = n;
                if (nn < 0)
                {
                    nn = -1 * nn;
                }

                while (nn > 0)
                {
                    if (nn % 2 == 1)
                    {
                        ans = ans * x;
                        nn = nn - 1;
                    }
                    else
                    {
                        x = x * x;
                        nn = nn / 2;
                    }
                }
                if (n < 0)
                {
                    ans = (double)(1.0) / (double)(ans);
                }
                return ans;
            }

            //Greatest Common Divisor
            static int GCD(int A, int B)
            {
                int divisor = 0;
                int dividend = 0;
                int n = 1;

                if (A > B)
                {
                    dividend = A; divisor = B;
                }
                if (B > A)
                {
                    dividend = B; divisor = A;
                }
                while (n != 0)
                {
                    n = dividend % divisor;
                    if (n != 0)
                    {
                        dividend = divisor;
                        divisor = n;

                    }
                }

                return divisor;
            }

            static void FindAllDivisorOfNumber(int A)
            {

                for (int i = 1; i <= A; i++)
                {
                    if (A % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            static int perfectNumber(int n)
            {
                int sum = 0;
                for (int i = 1; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;

                        if (n / i != n)
                        {
                            sum += n / i;
                        }
                    }
                }

                return sum == n ? 1 : 0;
                //return sum;
            }

            static void LargestNumberinArray(params int[] n)
            {
                int largest = n[0];
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] > largest)
                    {
                        largest = n[i];
                    }
                }
                Console.WriteLine(largest);

            }

            static void SecondLargestNumber(params int[] n)
            {
                int largest = n[0];
                int secondlargest = int.MinValue;
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] > largest)
                    {
                        secondlargest = largest;
                        largest = n[i];
                    }
                    else if (n[i] < largest && n[i] > secondlargest)
                    {
                        secondlargest = n[i];
                    }

                }
                Console.WriteLine(secondlargest);
            }

            static void SecondSmallestNumber(params int[] n)
            {
                int smallest = n[0];
                int secondsmallest = int.MaxValue;
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] < smallest)
                    {
                        secondsmallest = smallest;
                        smallest = n[i];
                    }
                    else if (n[i] > smallest && n[i] < secondsmallest)
                    {
                        secondsmallest = n[i];
                    }

                }
                Console.WriteLine(secondsmallest);
            }

            static void RemoveDuplicate(params int[] arr)
            {
                int i = 0;

                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        arr[i + 1] = arr[j];
                        i++;
                    }
                }
                Console.WriteLine(i + 1);

            }


            static int[] testFunc(int[] val, int temp)
            {
                int num = 1;

                for (int i = 0; i < val.Length; i++)
                {
                    if (i != 0)
                    {
                        num = i;
                    }
                    for (int j = num; j < val.Length - 1; j++)
                    {
                        if (temp == (val[i] + val[j]))
                        {
                            Console.WriteLine(i);
                            Console.WriteLine(j);
                        }
                    }
                }
                return new int[] { 1, 2 };
            }

            //**************************************************     //Leedcode problem 1    //****************************************************

            static int[] addsum(int[] num, int target)
            {
                int firstcount = 0;
                int secondcount = 1;

                while (firstcount < num.Length)
                {
                    if (secondcount < num.Length)
                    {
                        if (num[firstcount] + num[secondcount] == target)
                        {
                            break;
                        }
                        secondcount++;
                    }
                    else
                    {
                        firstcount++;
                        secondcount = firstcount + 1;
                    }

                }
                return new int[] { firstcount, secondcount };
            }
        }
    }
