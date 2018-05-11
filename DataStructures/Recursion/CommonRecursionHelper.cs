// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CommonRecursionHelper.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.Recursion
{
    #region Usings

    using System.Collections.Generic;
    using System.Text;

    #endregion

    /// <summary>
    /// The common recursion helper.
    /// </summary>
    public class CommonRecursionHelper
    {
        /// <summary>
        /// The fibonacci values.
        /// </summary>
        private readonly Dictionary<int, int> fibonacciValues = new Dictionary<int, int>();

        /// <summary>
        /// The calculate fibonacci.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int CalculateFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (this.fibonacciValues.ContainsKey(n))
            {
                return this.fibonacciValues[n];
            }

            var result = this.CalculateFibonacci(n - 2) + this.CalculateFibonacci(n - 1);
            this.fibonacciValues[n] = result;
            return result;
        }

        /// <summary>
        /// The create fibonacci series.
        /// </summary>
        /// <param name="n">
        /// The n.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string CreateFibonacciSeries(int n)
        {
            var sb = new StringBuilder();
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    sb.Append(", ");
                }

                sb.Append(this.CalculateFibonacci(i));
            }

            return sb.ToString();
        }

        /// <summary>
        /// The find gcd.
        /// </summary>
        /// <param name="number1">
        /// The number 1.
        /// </param>
        /// <param name="number2">
        /// The number 2.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int FindGCD(int number1, int number2)
        {
            // Using Euclid's Algorithm
            var remainder = number1 % number2;

            if (remainder == 0)
            {
                return number2;
            }

            return this.FindGCD(number2, remainder);
        }

        /// <summary>
        /// The sum digits.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int SumDigits(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            var remaining = number % 10;
            var newNumber = number / 10;
            return remaining + this.SumDigits(newNumber);
        }

        /// <summary>
        /// The to binary.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ToBinary(int number)
        {
            return this.ToBase(number, 2);
        }

        /// <summary>
        /// The to hex.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ToHex(int number)
        {
            return this.ToBase(number, 16);
        }

        /// <summary>
        /// The to octal.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ToOctal(int number)
        {
            return this.ToBase(number, 8);
        }

        /// <summary>
        /// The to pow.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="power">
        /// The power.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int ToPow(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            if (power == 1)
            {
                return number;
            }

            return number * this.ToPow(number, power - 1);
        }

        /// <summary>
        /// The to base.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <param name="baseNumber">
        /// The base number.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string ToBase(int number, int baseNumber)
        {
            var remainder = number % baseNumber;
            number = number / baseNumber;

            if (number == 0)
            {
                switch (remainder)
                {
                    case 10:
                        return "A";
                    case 11:
                        return "B";
                    case 12:
                        return "C";
                    case 13:
                        return "D";
                    case 14:
                        return "E";
                    case 15:
                        return "F";
                    default:
                        return remainder.ToString();
                }
            }

            return this.ToBase(number, baseNumber) + remainder.ToString();
        }
    }
}