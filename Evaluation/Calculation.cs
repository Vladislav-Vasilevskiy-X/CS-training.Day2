using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    public static class Calculation
    {
        public static double Evaluate(double number, int power, double accuracy)
        {
            if (IsPositive(power) && IsCorrectAccuracy(accuracy))
            {
                if(IsEven(power))
                {
                    if (number > 0) return MakeEvaluation(number, power, accuracy);
                    else return 0.0;
                }
                else
                {
                    return MakeEvaluation(number, power, accuracy);
                }
            }
            else return 0.0;
        }

        private static double MakeEvaluation(double number, double power, double accuracy)
        {
            double result = 1;

            while (true)
            {
                double currentValue = 1 / power * ((power - 1) * result + number / (Math.Pow(result, power - 1)));
                if (Math.Abs(result - currentValue) < accuracy) break;
                result = currentValue;
            }

            return result;
        }

        private static bool IsCorrectAccuracy(double accuracy)
        {
            if (accuracy > 0 && accuracy < 1) return true;
            else return false;
        }

        private static bool IsEven(int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }

        private static bool IsPositive(int number)
        {
            if (number >= 0) return true;
            else return false;
        }
    }
}
