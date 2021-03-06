﻿using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(2, 2, 4)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }



        [Test]
        public void Accumulator_Add()
        {
            _uut.Add(2, 2);

            Assert.That(_uut.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Accumulator_Substract()
        {
            _uut.Subtract(2, 2);

            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Accumulator_Multiply()
        {
            _uut.Multiply(2, 2);

            Assert.That(_uut.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Accumulator_Power()
        {
            _uut.Power(2, 2);

            Assert.That(_uut.Accumulator, Is.EqualTo(4));
        }



        [TestCase(8, 2, 4)]
        public void Divide_NumberWithAnotherNumber_Result(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(5, 0, "False")]
        public void Divide_NumberWithZero_ResultIsWrong(double a, double b, string result)
        {
            Assert.Throws(Is.TypeOf<ArgumentException>(), () => _uut.Divide(a, b));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        //[TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(-4, 5.7, "False")]
        public void Power_RaiseNumbers_ResultIsWrong(double x, double exp, string result)
        {
            Assert.Throws(Is.TypeOf<ArgumentException>(), () => _uut.Power(x, exp));
        }

        [Test]
        public void Clear_ClearAccumulator_AccumulatorIsZero()
        {
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
    }
}
