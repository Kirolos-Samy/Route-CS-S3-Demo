using System.Globalization;

namespace Route_CS_S3_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V1 - Fractions & Discard
            //float myFloat = 1.23456780F;
            //Console.WriteLine(myFloat);

            //double myDouble = 1.23456789012345678216516516590D;
            //Console.WriteLine(myDouble);

            //decimal myDecimal = 1_0.2_32515614165_1641415641451_1651511415M;
            //Console.WriteLine(myDecimal);

            //long x = 100_000_000;
            //CultureInfo culture = new CultureInfo("en-US");
            //Console.WriteLine($"{x:c}");
            #endregion

            #region V2 - Casting
            //int x = 10000; // 4 Bytes
            //long y = x; // 8 Bytes - Implicit Casting
            //Console.WriteLine(y); // 10000

            //long a = 10000; // 8 Bytes
            ////int b = a; // Invalid implicit casting
            //int b = (int)a; // Explicit Casting
            //Console.WriteLine(b); // 10000

            //long A = 100000000000;
            //int B = (int)A; // Explicit Casting - Data Loss
            //Console.WriteLine(B);

            //checked
            //{
            //    long A = 100000000000;
            //    int B = (int)A; // 'Arithmetic operation resulted in an overflow.'
            //    unchecked
            //    {
            //        Console.WriteLine(B);
            //    }
            //} 
            #endregion

            #region V3 - Convert
            //Console.WriteLine("Enter Your Data");
            //Console.Write("Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "No Name";

            //Console.Write("Enter Your Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Your Salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Your Data Is");
            //Console.WriteLine($"Name: {Name}");
            //Console.WriteLine($"Age: {Age}");
            //Console.WriteLine($"Salary: {salary}");
            #endregion

            #region V3 - Parse
            //Console.WriteLine("Enter Your Data");
            //Console.Write("Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "No Name";

            //Console.Write("Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write("Enter Your Salary: ");
            //decimal salary = decimal.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Your Data Is");
            //Console.WriteLine($"Name: {Name}");
            //Console.WriteLine($"Age: {Age}");
            //Console.WriteLine($"Salary: {salary}"); 
            #endregion

            #region V3 - TryParse
            //Console.WriteLine("Enter Your Data");
            //Console.Write("Enter Your Name: ");
            //string Name = Console.ReadLine() ?? "No Name";

            //Console.Write("Enter Your Age: ");
            //int Age;
            //bool isAgeParsed = int.TryParse(Console.ReadLine(), out Age);

            //Console.Write("Enter Your Salary: ");
            //bool isSalaryParsed = decimal.TryParse(Console.ReadLine(), out decimal salary);

            //Console.Clear();
            //Console.WriteLine("Your Data Is");
            //Console.WriteLine($"Name: {Name}");
            //Console.WriteLine($"Age: {Age}, is Age parsed: {isAgeParsed}");
            //Console.WriteLine($"Salary: {salary}, is Salary parsed: {isSalaryParsed}"); 
            #endregion

            #region V4 - Unary Operators
            //int x = 5;

            /// ++
            // 1.1 Prefix
            //++x; //6
            //int y = 10;
            //int sum = ++x + y; //16
            //Console.WriteLine(++x); // 6
            //Console.WriteLine(x); // 6

            // 1.2 Postfix
            //x++; // 6
            //int y = 10;
            //int sum = x++ + y; //15
            //Console.WriteLine(x++); // 5
            //Console.WriteLine(x); // 6

            // 2.1 Prefix
            //Console.WriteLine(--x); // 4
            //Console.WriteLine(x); //4

            // 2.2 Postfix
            //Console.WriteLine(x--); // 5
            //Console.WriteLine(x); // 4 
            #endregion

            #region V4 - Binary Operators
            //int x = 9, y = 5, Result;

            //Result = x + y; // 14
            //Result = x - y; // 4
            //Result = x * y; // 45
            //Result = x / y; // 1
            //Result = x % y;

            //Console.WriteLine(x / (double) y);
            //Console.WriteLine(Result); 
            #endregion

            #region V4 - Assignment Operators
            //int x;
            //x = 5;
            //x = x + 10;
            //x += 10;// 15
            //x -= 3; // 12
            //x *= 4; // 48
            //x /= 2; // 24
            //x %= 4; // 0 
            #endregion

            #region V4 - Relational Operators
            //int x = 5, y = 6;

            //Console.WriteLine(x == y); // False
            //Console.WriteLine(x != y); // True
            //Console.WriteLine(x > y);  // False
            //Console.WriteLine(x <= y); // True
            //Console.WriteLine(x >= y); // False
            //Console.WriteLine(x < y);  // True
            #endregion

            #region V4 - Logical Operators
            //int x = 5, y = 6;

            //Console.WriteLine(!(x == y)); // True
            //Console.WriteLine(!true); // false
            //Console.WriteLine(!false); // true

            //Console.WriteLine((x != y) && (y >= x)); // true
            //Console.WriteLine(true && true); // true
            //Console.WriteLine(true && false); // false
            //Console.WriteLine(false && true); // false
            //Console.WriteLine(false && false); // false

            //Console.WriteLine(true || true); // true
            //Console.WriteLine(true || false); // true
            //Console.WriteLine(false || true); // true
            //Console.WriteLine(false || false); // false 
            #endregion

            #region V4 - Bitwise Operators
            //  1  2  4  8 16 32 64
            //  1 0 1 0 0 0 0
            //  0 1 1 0 0 0 0
            //Console.WriteLine(5 | 6); // 7
            //  1 1 1 0 0 0 0

            //Console.WriteLine(5 & 6); // 4
            //  0 0 1 0 0 0 0

            //Console.WriteLine(5 ^ 6); // 3
            //  1 1 0 0 0 0 0

            //Console.WriteLine(~6);
            //  0 1 1 0 0 0 0

            //Console.WriteLine(5 << 1);
            //  1 0 1 0 0 0 0
            // 0 1 0 1 0 0 0

            //Console.WriteLine(5 >> 1);
            //  1 0 1 0 0 0 0
            // 0 0 1 0 0 0 0 
            #endregion

            #region V4 - Ternary Operator
            //int x=5, y = 6,z;

            //z = !(x > y) ? 2 : 3;

            //Console.WriteLine(z); 
            #endregion

            #region V5 - Operators Priority
            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int Result;

            //Result = (a + b) * c / d;  // 35 * c / d, 350 / d, 70
            //Result = ((a + b) * c) / d;  // 70
            //Result = (a + b) * (c / d);  // 35 * 2 = 70
            //Result = a + (b * c) / d;  // 20 + 150 / 5 = 20 + 30 = 50

            //Console.WriteLine(Result); 
            #endregion

            #region V6 - String Formatting
            /// Equation: x + y = Result
            /// Equation: 10 + 5 = 15
            //int x = 10, y = 5, Result;
            //Result = x + y;
            //string Message;

            // 1. String Interpolation
            //Message = $"Equation: {x} + {y} = {Result}";
            //Console.WriteLine(Message);

            // 2. String.Format method
            //Message = string.Format("Equation: {0} + {1} = {2}", x, y, Result);
            //Console.WriteLine(Message);

            // 3. Composite Formatting
            //Console.WriteLine("Equation: {0} + {1} = {2}", x, y, Result);

            // 4. String Concatenation
            //Message = "Equation: " + x + " + " + y + " = " + Result;
            //Console.WriteLine(Message); 
            #endregion

            #region V8 - Conditional (If & Switch) - Constant Pattern
            //Console.WriteLine("Enter Month from first Quarter");
            //int.TryParse(Console.ReadLine(), out int month);

            //if (month == 1)
            //{
            //    // Body
            //    Console.WriteLine("Hello Jan");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine("Hello Feb");
            //}
            //else if (month == 3)
            //{
            //    Console.WriteLine("Hello March");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Month");
            //}

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Hello Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello March");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month");
            //        break;
            //} 
            #endregion

            #region V9 - Conditional (If & Switch) - Relational Pattern
            //Console.WriteLine("Enter your Age");
            //int.TryParse(Console.ReadLine(), out int Age);

            ////if(Age > 22)
            ////{
            ////    Console.WriteLine("Age is greater than 22");
            ////}
            ////else if(Age < 22)
            ////{
            ////    Console.WriteLine("Age is Less than 22");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Age is Equal to 22");
            ////}

            ////switch (Age)
            ////{
            ////    case > 22:
            ////        Console.WriteLine("Age is greater than 22");
            ////        break;
            ////    case < 22:
            ////        Console.WriteLine("Age is Less than 22");
            ////        break;
            ////    default:
            ////        Console.WriteLine("Age is Equal to 22");
            ////        break;
            ////} 
            #endregion

        }
    }
}
