using System;

namespace ParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pass the value test:");
            int testVal1 = 1;
            Console.WriteLine("Original value: {0}", testVal1);
            Test(testVal1);
            Console.WriteLine("Returned value: {0}", testVal1);

            //Passing in the reference type
            Console.WriteLine("\nPass in a reference type test:");
            int[] testArray = { 1, 1, 1 };
            Console.WriteLine($"Original Value: {testArray[0]}");
            TestArray(testArray);
            Console.WriteLine($"Returned value: {testArray[0]}");

            Console.WriteLine("\nOut Paramater test:");
            //int testVal2 = 2;
            int testVal2;
            //Console.WriteLine($"Original Value: {testVal2}");
            TestOut(out testVal2);
            Console.WriteLine($"Returned Value: {testVal2}");


            Console.WriteLine("\nRef Parameter Test");
            int testVal3 = 3;
            Console.WriteLine($"Original Value: {testVal3}");
            TestRef(ref testVal3);
            Console.WriteLine($"Original Value: {testVal3}");

            Console.WriteLine("\nCalling the TestOptional Function w parameter");
            TestOptional(4);
            Console.WriteLine("\nCalling TestOptional Function wo Parameter");
            TestOptional();

            Console.WriteLine("\nTestMultiple with all three");
            TestMultiple(1, 2, 3);

            Console.WriteLine("\nTestMultiple with two");
            TestMultiple(1, 2);

            Console.WriteLine("\nTestMultiple with first and last");
            TestMultiple(1, cValue: 3);

            Console.WriteLine("\nTest overloaded method with string");
            TestOverloaded("Test string");

            Console.WriteLine("\nTest overloaded method with numbers");
            TestOverloaded(5, 5.5);


        }
        public static void Test(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In Test Value is {0}", aValue);
        }

        public static void TestArray(int[] anArray)
        {
            anArray[0] = 111;
            Console.WriteLine($"The Test Value is {anArray[0]}");
        }

        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine($"Test out value is: {aValue}");
        }

        static void TestRef(ref int aValue)
        {
            aValue = 333;
            Console.WriteLine($"TestRef Value is {aValue}");
        }

        private static void TestOptional(int aValue = 444)
        {
            Console.WriteLine($"TestOptional Value is {aValue}");
        }

        private static void TestMultiple(int aValue, int bValue = 222, int cValue = 333)
        {
            Console.WriteLine($"TestMultiple: {aValue}, {bValue}, {cValue}");
        }

        private static void TestOverloaded(string strParam)
        {
            Console.WriteLine($"Numeric overload called with the values of {strParam}");
        }

        private static void TestOverloaded(int intParam, double dblParam)
        {
            Console.WriteLine($"Numeric overload called with the values of {intParam} and {dblParam}");
        }
    }
}
