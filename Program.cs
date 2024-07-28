// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text;


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
        //ReverseEquation("82 -2*5/3-1+70");
        //bool tr = Rec_palindrome("MALAYALAM",9,0);
        //Console.WriteLine(tr);
        //print_divisors(36);
        //commonfactor(25,30);
        //multiplyTwoStrings("-28", "79");
        //int[] a = RemoveDuplicates(1,2,2,2,3,4,4);
        //foreach (int b in a) {
        //    Console.WriteLine(b);
        //}
        //int[] a = { 11, 15, 2, 3,6,8,1,0,7};
        //TwoSuming(a, 9);
        //FindMaxConsecutiveOnes(1,1, 0, 1, 1, 1);
        //bubbleSort_leed(4, 1, 3, 9, 7);
        //MissingNumber(1);
        //sumOfPrimes(1453);
        //Rotate(1, 2, 3, 4, 5, 6, 7);
        //int a = RemoveDuplicates1(0, 0, 1, 1, 1, 2, 2, 3, 3, 4);
        //MoveZeroes(0, 1, 0, 3, 12);
        //twosumsAprroach1(2,7,5,9,6);
        //twosumsAprroach2(5,6,7,9,2);
        //InsertionSort(12, 11, 13, 5, 6);
        //mergeSort();
        //mergeSortedArray();
        //testf();
        //int a = majorityElement();
        //int a = majorityElement2();
        //int[] a = missingAndRepeating();
        //SortColors();
        //int[] a = NextPermutation();
        //foreach (int b in a)
        //{
        //    Console.WriteLine(b);
        //}
        //List<List<int>> ans = triplet();
        //MaxSumOfSubArray();
        //MaxOfProductSubArray();
        //kthElementOfTwoSortedArrays();
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
            //"82-2*5/3-1+70"
            Stack<string> stk = new Stack<string>();
            string current = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    current += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(current))
                    {
                        stk.Push(current);
                        current = "";
                    }
                    stk.Push(c.ToString());
                }
            }
            if (!string.IsNullOrEmpty(current))
            {
                stk.Push(current);
            }
            Console.WriteLine(string.Concat(stk.ToArray()));
        }



        static void sumOfPrimes(int N)
        {
            int sum = 0;
            for (int i = 2; i <= N; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }


        static void printTables(int n)
        {
            List<int> dt = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                dt.Add(i * n);
            }
            foreach (int i in dt)
            {
                Console.Write(i + ",");
            }
            dt.Sort();
        }

        static void numberofDigits(int a)
        {
            int n = 0;

            while (a > 0)
            {
                n++;
                a = a / 10;
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

        static void commonfactor(int a, int b)
        {
            int min = Math.Min(a, b);
            int count = 0;

            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void multiplyTwoStrings(string num1, string num2)
        {
            bool isNegative = false;

            if (num1[0] == '-')
            {
                isNegative = !isNegative;
                num1 = num1.Substring(1);
            }
            if (num2[0] == '-')
            {
                isNegative = !isNegative;
                num2 = num2.Substring(1);
            }
            int n = num1.Length;
            int m = num2.Length;

            int[] val = new int[n + m];


            for (int i = n - 1; i <= 0; i--)
            {
                for (int j = m - 1; j <= 0; j--)
                {
                    int mul = (num1[i] - '0') * (num2[j] - '0');
                    int sum = mul + val[i + j + 1];
                    val[i + j + 1] = sum % 10;
                    val[i + j] += sum / 10;
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var c in val)
            {
                if (!(sb.Length == 0 || c == 0))
                {
                    sb.Append(c);
                }
            }
            if (sb.Length == 0)
            {
                Console.WriteLine("0");
                //break;
            }

            else if (isNegative)
            {
                sb.Insert(0, "-");
            }

            Console.WriteLine(sb.ToString());
        }

        static void Rotate(params int[] arr)
        {
            //(1, 2, 3, 4, 5, 6, 7)
            int K = 3;


            for (int j = 0; j < K; j++)
            {
                int x = arr[(arr.Length - 1)];
                for (int i = (arr.Length - 1); i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = x;
            }


        }

        static void FindMaxConsecutiveOnes(params int[] nums)
        {
            //1,1, 0, 1, 1, 1
            int count = 0;
            int Currentlargest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count += 1;
                        if (Currentlargest < count)
                        {
                            Currentlargest = count;
                        }
                        //Currentlargest = count;
                    }
                    else
                    {
                        count = 0;
                        break;
                    }
                }
            }
            Console.WriteLine(Currentlargest + 1);
        }

        static void bubbleSort_leed(params int[] value)
        {
            int temp = 0;
            for (int i = 0; i < value.Length; i++)
            {
                for (int j = 0; j < value.Length - 1; j++)
                {
                    if (value[j] > value[j + 1])
                    {
                        temp = value[j];
                        value[j] = value[j + 1];
                        value[j + 1] = temp;

                    }
                }
            }

            foreach (int a in value)
            {
                Console.Write(a + " ");
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

        static void leastPrimeFactor(int n)
        {
            int[] least_prime = new int[n + 1];

            least_prime[1] = 1;

            for (int i = 2; i <= n; i++)
            {

                if (least_prime[i] == 0)
                {
                    least_prime[i] = i;

                    for (int j = i * i; j <= n; j += i)
                        if (least_prime[j] == 0)
                            least_prime[j] = i;
                }
            }

            // print least prime factor of
            // of numbers till n
            for (int i = 1; i <= n; i++)
                Console.WriteLine("Least Prime factor of " +
                                i + ": " + least_prime[i]);
        }

        static void RemoveDuplicate(params int[] arr)
        {
            //1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 7, 7, 7
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
        static int MissingNumber(params int[] nums)
        {

            int temp = 0;
            int val = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < nums.Length; k++)
            {
                if (k != nums[k])
                {
                    val = k;
                    break;
                }
            }

            return val;
        }
        static int RemoveDuplicates1(params int[] nums)
        {
            int i = 0;

            foreach (int num in nums)
                if (i < 1 || num > nums[i - 1])
                    nums[i++] = num;

            return i;
        }

        static void recs(int N)
        {
            if (N == 0)
            {
                return;
            }

            recs(N - 1);

            Console.WriteLine(N);
        }
        static bool Rec_palindrome(string val, int n, int i) 
        {

            if (i >= n / 2) {
                return true;
            }

            if (val[i] != val[n - i - 1]) {
                return false;
            }

           return Rec_palindrome(val, n, i+1);

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

        static void twosumsAprroach1(params int[] a)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int target = 11;
            for (int i = 0; i < a.Length; i++)
            {
                int total = target - a[i];
                if (dict.ContainsKey(total))
                {
                    Console.WriteLine(dict[total] + "," + i);
                }
                else
                {
                    dict.Add(a[i], i);
                }
            }
        }

        static void twosumsAprroach2(params int[] nums)
        {
            bool flag = false;
            int target = 11;
            int i, j = 0;
            for (i = 0; i < nums.Length; i++)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        flag = true;
                        Console.WriteLine(i + "," + j);
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("No match found");
                }
            }
        }


        static void InsertionSort(params int[] array)
        {
            //12, 11, 13, 5, 6
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key,
                // to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            foreach (int v in array)
            {
                Console.Write(v + ",");
            }
        }


        //merge Sort starts

             static void merge(int[] arr, int low, int mid, int high)
             {
                 //1,3,9,7
                 int left = low;
                 int right = mid + 1;
                 List<int> temp = new List<int>();

                   while (left <= mid && right <= high)
                   {
                        if (arr[left] <= arr[right])
                        {
                          temp.Add(arr[left]);
                          left++;
                        }
                        else
                        {
                            temp.Add(arr[right]);
                            right++;
                        }
                   }
       
                    while(left<=mid)
                    {
                       temp.Add(arr[left]);
                       left++;
                     }
                    while (right <= high)
                    {
                        temp.Add(arr[right]);
                        right++;
                    }

                    for (int i = low; i <= high; i++)
                    {
                        arr[i] = temp[i - low];
                    }
             }

            void mS(int[] arr, int low, int high)
            {
                if (low >= high) return;

                int mid = (low + high) / 2;

                mS(arr, low, mid);
                mS(arr, mid + 1, high);
                merge(arr, low, mid, high);

            }

            void mergeSort()
            {
              int[] arr = {3,1,9,7};
              int l = 0;
              int r = 3;
              mS(arr, l, r);

            foreach (int a in arr) { 
              Console.Write(a+",");
            }

            }

//merge Sort ends

        static int[] missingAndRepeating() 
        {
            int[] arr = { 1, 3, 3, 4, 5, 6 };

            Dictionary<int, int> Dict = new Dictionary<int, int>();
            int[] result = new int[2];
            int repeating = -1, missing = -1;

            for (int i = 0; i < arr.Length; i++) {

                if (Dict.ContainsKey(arr[i])) Dict[arr[i]]++;
                else Dict[arr[i]] = 1;

                //if (Dict[arr[i]]>1) result[0] =  Dict[arr[i]];

                //if (!Dict.ContainsKey(i)) result[1] = i;

            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (Dict[j] == 2) repeating = j;
                if (Dict[j] == 0) missing = j;

                if (repeating != -1 && missing != -1) break; 
            }

            return new int[] { repeating, missing};
        }

        

        static void MoveZeroes(params int[] nums)
        {
             //0, 1, 0, 3, 12
             int temp = 0;
             for (int i = 0; i < nums.Length - 1; i++)
             {
                if (nums[i] == 0)
                {
                        temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                }

             }
              foreach (int a in nums)
              {
                 Console.Write(a + " ");
              }
        }

        static void SortColors()
        {
            int[] nums = { 2,0,2,1,1,0};
            int right = nums.Length - 1, left = 0, temp = 0;


            for (int i = 0; i < nums.Length; i++) {
                while (left <= right)
                {
                    if (nums[left] == 2)
                    {
                        temp = nums[right];
                        nums[right] = nums[left];
                        nums[left] = temp;
                        right--;
                    }
                    else if (nums[right] == 0)
                    {
                        temp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = temp;
                        left++;
                    }
                    else {
                        left++;
                        right--;
                    }
                }
            }
            

            foreach (int v in nums) { 
             Console.Write(v + " ");
            }
        }

        static int[] NextPermutation()
        {
            int[] nums = { 3, 2, 1 };
            int n = nums.Length;
            int i = n - 2;

            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = n - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }

            nums = Reverse(nums, i + 1, n - 1);

            foreach (int g in nums) {
                Console.Write(g + ",");
            }
            return nums;
        }

        static int[] Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
            return nums;
        }

        static int[] Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                Swap(nums, start, end);
                start++;
                end--;
            }
            return nums;
        }

        static int[] rev(int[] array, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                int temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
            return array;
        }


        static void mergeSortedArray()
        {

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;


            int i = m - 1;  
            int j = n - 1;  
            int k = m + n - 1;  

            // Start merging from the end
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }

            // If there are remaining elements in nums2
            while (j >= 0)
            {
                nums1[k--] = nums2[j--];
            }
        }

        static int majorityElement()
        {
            int[] numbers = new int[] { 1, 2, 3, 1, 2, 1,1 };

            int half = numbers.Length / 2;

            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++) {
                if (numberCounts.ContainsKey(numbers[i])) numberCounts[numbers[i]]++;
                
                else numberCounts[numbers[i]] = 1;

                if (numberCounts[numbers[i]] > half) return numbers[i];
            }
            return -1;
        }

        static int majorityElement2()
        {
            int[] nums = new int[] { 1, 2, 3, 1, 2, 1, 1 };

            int count = 0, el = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0) el = nums[i];

                if (nums[i] == el) count++;

                else count--;

            }
            count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == el) count++;
                if (count > nums.Length / 2) return nums[j];
            }
            return -1;
        }

        static void printNos(int N)
        {
            if (N == 0)
            {
                return;
            }

            Console.Write(N + " ");
            printNos(N - 1);
        }

        static void printNos2(int N)
        {
            if (N == 0)
            {
                return;
            }

            
            printNos2(N - 1);
            Console.Write(N + " ");
        }

        static List<List<int>> triplet()
        {
            int[] arr = { -1, 0, 1, 2, -1, -4 };
            List<List<int>> st = new List<List<int>>();

            //Dictionary<int, int> Dict = new Dictionary<int,int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1]) continue;

                int j = i + 1;
                int k = arr.Length - 1;
                while (j < k)
                {
                    int sum = arr[i] + arr[j] + arr[k];
                    if (sum < 0) {
                        j++;
                    }
                    else if (sum > 0) {
                        k--;
                    } 
                    else
                    {
                        List<int> temp = new List<int> { arr[i], arr[j], arr[k] };
                        temp.Sort();
                        st.Add(temp);
                        j++;
                        k--;
                        while (j < k && arr[j] == arr[j - 1]) j++;
                        while (j < k && arr[k] == arr[k + 1]) k--;
                    }
                }
            }

            return st;
        }


        static int MaxSumOfSubArray()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int pre = 0, suff = 0, max = Int32.MinValue;
            if (nums.Length == null || nums.Length == 0) return 0;

            if (nums.Length == 1) return nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (pre < 0) pre = 0;
                if (suff < 0) suff = 0;

                pre = pre + nums[i];
                suff = suff + nums[nums.Length - i - 1];
                max = Math.Max(max, Math.Max(pre, suff));
            }

            return max;
        }

        static int MaxOfProductSubArray()
        {
            int[] nums = { 0, 10, 10, 10, 10, 10, 10, 10, 10, 10, -10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 0 };
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            BigInteger pre = 1, suff = 1, max = Int32.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (pre == 0) pre = 1;
                if (suff == 0) suff = 1;

                pre = pre * nums[i];
                suff = suff * nums[nums.Length - 1 - i];
                max = BigInteger.Max(max, BigInteger.Max(pre, suff));
            }

            return (int)max;
        }
        static int kthElementOfTwoSortedArrays()
        {
            int[] arr1 = { 2, 3, 6, 7, 9 };
            int[] arr2 = { 1, 4, 8, 10 };
            int k = 3;
            int m = arr1.Length, n = arr2.Length;

            int left = 0, right = 0, count = 0;
            int[] temp = new int[m + n];

            while (left < n && right < m)
            {
                if (arr1[left] < arr2[right]) temp[count++] = arr1[left++];
                else temp[count++] = arr2[right++];
            }

            while (left < arr1.Length) temp[count++] = arr1[left++];

            while (right < arr2.Length) temp[count++] = arr2[right++];

            return temp[k - 1];
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