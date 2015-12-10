using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EuclidianAlg
{
    public static class Calculation
    {
        public static long lastOperationTimeInMilliseconds = 0;
        public static Stopwatch stopwatch = new Stopwatch();

        public static int GCD(int number)
        {
            lastOperationTimeInMilliseconds = 0;
            return number;
        }

        public static int GCDBinary(int number)
        {
            lastOperationTimeInMilliseconds = 0;
            return number;
        }

        public static int GCD(int number1, int number2)
        {
            StartTime();
            int value;
            while (number2 > 0)
            {
                value = number1 % number2;
                number1 = number2;
                number2 = value;
            }
            StopTime();
            return Math.Abs(number1);
        }

        public static int GCDBinary(int number1, int number2)
        {
            StartTime();
            if (number1 == 0)
                return number2;

            if (number2 == 0 || number1 == number2)
                return number1;

            if (number1 == 1 || number2 == 1)
                return 1;

            if ((number1 % 2 == 0) && (number2 % 2 == 0))
                return 2 * GCDBinary(number1 / 2, number2 / 2);

            if ((number1 % 2 == 0) && (number2 % 2 != 0))
                return GCDBinary(number1 / 2, number2);

            if ((number1 % 2 != 0) && (number2 % 2 == 0))
                return GCDBinary(number1, number2 / 2);
    
            StopTime();
            return GCDBinary(number2, Math.Abs(number1 - number2));
        }

        public static int GCD(int number1, int number2, int number3)
        {
            StartTime();
            int value = GCD(GCD(number1, number2), number3);

            StopTime();
            return value;
        }

        public static int GCDBinary(int number1, int number2, int number3)
        {
            StartTime();
            int value = GCDBinary(GCDBinary(number1, number2), number3);

            StopTime();
            return value;
        }

        public static int GCD(params int[] numbers)
        {
            StartTime();
            int value = 0;
            foreach(int number in numbers)
            {
                value = GCD(number, value);
            }
            StopTime();
            return value;
        }

        public static int GCDBinary(params int[] numbers)
        {
            StartTime();
            int value = 0;
            foreach (int number in numbers)
            {
                value = GCDBinary(number, value);
            }
            StopTime();
            return value;
        }

        private static void StartTime()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        private static void StopTime()
        {
            stopwatch.Stop();
            lastOperationTimeInMilliseconds = stopwatch.ElapsedMilliseconds;
        }


    }
}
