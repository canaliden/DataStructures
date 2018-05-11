// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PolishNotationHelper.cs" company="Ali Can">
//   Free to use
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.PolishNotation
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Text;

    #endregion

    /// <summary>
    /// The polish notation helper.
    /// </summary>
    public class PolishNotationHelper
    {
        /// <summary>
        /// The operator stack.
        /// </summary>
        private readonly Stack<char> operatorStack;

        /// <summary>
        /// The value stack.
        /// </summary>
        private readonly Stack<int> valueStack;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolishNotationHelper"/> class.
        /// </summary>
        public PolishNotationHelper()
        {
            this.operatorStack = new Stack<char>();
            this.valueStack = new Stack<int>();
        }

        /// <summary>
        /// The evaluate postfix.
        /// </summary>
        /// <param name="postfix">
        /// The postfix.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int EvaluatePostfix(string postfix)
        {
            foreach (var c in postfix)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (char.IsDigit(c))
                {
                    this.valueStack.Push(Convert.ToInt32(c.ToString()));
                }
                else if (this.IsOperator(c))
                {
                    var op2 = this.valueStack.Pop();
                    var op1 = this.valueStack.Pop();
                    this.valueStack.Push(this.ExecuteOperation(c, op1, op2));
                }
            }

            if (this.valueStack.Count == 0)
            {
                return 0;
            }

            return this.valueStack.Pop();
        }

        /// <summary>
        /// The execute operation.
        /// </summary>
        /// <param name="operation">
        /// The operation.
        /// </param>
        /// <param name="op1">
        /// The op 1.
        /// </param>
        /// <param name="op2">
        /// The op 2.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int ExecuteOperation(char operation, int op1, int op2)
        {
            switch (operation)
            {
                case '+':
                    return op1 + op2;
                case '-':
                    return op1 - op2;
                case '*':
                    return op1 * op2;
                case '/':
                    return op1 / op2;
                case '^':
                    return (int)Math.Pow(op1, op2);
            }

            return 0;
        }

        /// <summary>
        /// The ıs new char equal or higher ın precedence.
        /// </summary>
        /// <param name="peekedFromStack">
        /// The peeked from stack.
        /// </param>
        /// <param name="newChar">
        /// The new char.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsNewCharEqualOrHigherInPrecedence(char peekedFromStack, char newChar)
        {
            if (peekedFromStack == '^')
            {
                return true;
            }

            if (peekedFromStack == '*' || peekedFromStack == '/')
            {
                return newChar != '^';
            }

            if ((peekedFromStack == '+' || peekedFromStack == '-') && (newChar == '+' || newChar == '-'))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// The ıs operator.
        /// </summary>
        /// <param name="c">
        /// The c.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsOperator(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                case '^':
                    return true;
            }

            return false;
        }

        /// <summary>
        /// The ıs parantesis.
        /// </summary>
        /// <param name="c">
        /// The c.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsParantesis(char c)
        {
            switch (c)
            {
                case '(':
                case ')':
                    return true;
            }

            return false;
        }

        /// <summary>
        /// The to postfix.
        /// </summary>
        /// <param name="infix">
        /// The infix.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ToPostfix(string infix)
        {
            var sb = new StringBuilder();

            var parantesisOpen = false;
            foreach (var c in infix)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (!this.IsOperator(c) && !this.IsParantesis(c))
                {
                    sb.Append(c);
                }
                else if (c == '(')
                {
                    parantesisOpen = true;
                    this.operatorStack.Push(c);
                }
                else if (c == ')')
                {
                    while (this.operatorStack.Count > 0)
                    {
                        var chr = this.operatorStack.Pop();
                        if (chr == '(')
                        {
                            break;
                        }

                        sb.Append(chr);
                    }

                    parantesisOpen = false;
                }
                else if (this.operatorStack.Count == 0 || parantesisOpen)
                {
                    this.operatorStack.Push(c);
                }
                else if (this.IsNewCharEqualOrHigherInPrecedence(this.operatorStack.Peek(), c))
                {
                    sb.Append(this.operatorStack.Pop());
                    this.operatorStack.Push(c);
                }
            }

            while (this.operatorStack.Count > 0)
            {
                sb.Append(this.operatorStack.Pop());
            }

            return sb.ToString();
        }
    }
}