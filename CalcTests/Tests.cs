using NUnit.Framework;
using System;
using System.Linq;

namespace CalcTests
{
    public class Tests
    {
        [SetUp]
        public void PreCondition()
        {
            Console.WriteLine("Pre-condition");
        }
        [TearDown]
        public void PostCondition()
        {
            Console.WriteLine("Post-condition");
        }

        [Test]
        public static void SumTest1()
        {
            Console.WriteLine("SumTest1");
            double actual = Calc.Sum(2, 3);
            Assert.AreEqual(actual, 5);
        }
        [Test]
        public static void SumTest2()
        {
            Console.WriteLine("SumTest2-notnull");
            double actual = Calc.Sum(3, 1);
            Assert.NotNull(actual);
        }
        [Test]
        public static void SumTest3()
        {
            Console.WriteLine("SumTest3-positive");
            double actual = Calc.Sum(3, 1);
            Assert.Positive(actual);
        }
        [Test]
        public static void SumTest4()
        {
            Console.WriteLine("SumTest4-Negative");
            double actual = Calc.Sum(-3, 1);
            Assert.Negative(actual);
        }
        [Test]
        public static void SumTest5()
        {
            Console.WriteLine("SumTest5-Negative");
            double actual = Calc.Sum(-3, 0);
            Assert.Negative(actual);
        }

        [Test]
        public static void DiffTest1()
        {
            Console.WriteLine("DiffTest1");
            double actual = Calc.Difference(2, 3);
            Assert.AreEqual(actual, -1);
        }
        [Test]
        public static void DiffTest2()
        {
            Console.WriteLine("DiffTest2-NotZero");
            double actual = Calc.Difference(2, 3);
            Assert.NotZero(actual);
        }
        [Test]
        public static void DiffTest3()
        {
            Console.WriteLine("DiffTest3-Negative");
            double actual = Calc.Difference(2, 3);
            Assert.Negative(actual);
        }
        [Test]
        public static void DiffTest4()
        {
            Console.WriteLine("DiffTest4-Zero");
            double actual = Calc.Difference(0, 0);
            Assert.Zero(actual);
        }
        [Test]
        public static void DiffTest5()
        {
            Console.WriteLine("DiffTest4-less");
            double actual = Calc.Difference(0, 6);
            Assert.Less(actual, 0);
        }

        [Test]
        public static void DivisionTest1()
        {
            Console.WriteLine("DivisionTest1");
            double actual = Calc.Division(2, 2);
            Assert.AreEqual(actual, 1);
        }
        [Test]
        public static void DivisionTest2()
        {
            Console.WriteLine("DivisionTest2-NotZero");
            double actual = Calc.Division(2, 2);
            Assert.NotZero(actual);
        }
        [Test]
        public static void DivisionTest3()
        {
            Console.WriteLine("DivisionTest3-less or equel");
            double actual = Calc.Division(1, 3);
            Assert.LessOrEqual(actual, 1);
        }
        [Test]
        public static void DivisionTest4()
        {
            Console.WriteLine("DivisionTest4-Less");
            double actual = Calc.Division(3, 4);
            Assert.Less(actual,1);
        }
        [Test]
        public static void DivisionTest5()
        {
            Console.WriteLine("DivisionTest4-null");
            double actual = Calc.Division(0, 4);
            Assert.Zero(actual);
        }

        [Test]
        public static void MultiplicationTest1()
        {
            Console.WriteLine("MultiplicationTest1");
            double actual = Calc.Multiplication(2, 2);
            Assert.AreEqual(actual, 4);
        }
        [Test]
        public static void MultiplicationTest2()
        {
            Console.WriteLine("MultiplicationTest2-NotZero");
            double actual = Calc.Multiplication(2, 2);
            Assert.NotZero(actual);
        }
        [Test]
        public static void MultiplicationTest3()
        {
            Console.WriteLine("MultiplicationTest3-Positive");
            double actual = Calc.Multiplication(2, 3);
            Assert.Positive(actual);
        }
        [Test]
        public static void MultiplicationTest4()
        {
            Console.WriteLine("MultiplicationTest4-Negative");
            double actual = Calc.Multiplication(-2, 3);
            Assert.Negative(actual);
        }
        [Test]
        public static void MultiplicationTest5()
        {
            Console.WriteLine("MultiplicationTest5-Positive");
            double actual = Calc.Multiplication(-2, -3);
            Assert.Positive(actual);
        }
    }
}
