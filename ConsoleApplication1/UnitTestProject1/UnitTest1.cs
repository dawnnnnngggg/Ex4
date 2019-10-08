using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result1 = Program.IsOdd(3);
            Assert.AreEqual(true, result1);
            bool result2 = Program.IsOdd(4);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void TestIsEven()
        {
            bool result3 = Program.IsEven(3);
            Assert.AreEqual(false, result3);
            bool result4 = Program.IsEven(4);
            Assert.AreEqual(true, result4);
        }
        [TestMethod]
        public void TestIsPrime()
        {
            bool result5 = Program.IsPrime(3);
            Assert.AreEqual(true, result5);
            bool result6 = Program.IsPrime(6);
            Assert.AreEqual(false, result6);
        }
        [TestMethod]
        public void TestSquare()
        {
            int result7 = Program.Square(-3);
            Assert.AreEqual(9, result7);
            int result8 = Program.Square(4);
            Assert.AreEqual(16, result8);
        }
        [TestMethod]
        public void TestCube()
        {
            int result1 = Program.Cube(-3);
            Assert.AreEqual(-27, result1);
            int result2 = Program.Cube(3);
            Assert.AreEqual(27, result2);
        }
        [TestMethod]
        public void TestPow()
        {
            double result3 = Program.Pow(0, 2);
            Assert.AreEqual(0, result3);
            double result4 = Program.Pow(2, 2);
            Assert.AreEqual(4, result4);
            double result5 = Program.Pow(-2, -3);
            Assert.AreEqual(-0.125, result5);
        }
        [TestMethod]
        public void TestAbs()
        {
            int result6 = Program.Abs(-2);
            Assert.AreEqual(2, result6);
            int result7 = Program.Abs(2);
            Assert.AreEqual(2, result7);
        }
        [TestMethod]
        public void TestCeli()
        {
            int result8 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2, result8);
            int result9 = Program.Ceil(2.3f);
            Assert.AreEqual(3, result9);
        }
        [TestMethod]
        public void TestFloor()
        {
            int result1 = Program.Floor(-2.3f);
            Assert.AreEqual(-3, result1);
            int result2 = Program.Floor(2.3f);
            Assert.AreEqual(2, result2);
        }
        [TestMethod]
        public void TestFactorial()
        {
            long result1 = Program.Factorial(4);
            Assert.AreEqual(24, result1);
        }

        //[TestMethod]
        //public void TestEquation()
        //{
        //    double result1 = Program.Equation(2);
        //    Assert.AreEqual(Math.Sin(2), result1);
        //}
        [TestMethod]
        public void TestIsContains5()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program.IsContains5(arr1);
            Assert.AreEqual(true, result1);
            int[] arr2 = new int[] { 6, 7, 8, 9 };
            bool result2 = Program.IsContains5(arr2);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void TestIsContains5or6()
        {
            int[] arr4 = new[] { 1, 2, 3, 4, 5, 6 };
            bool result1 = Program.IsContains5or6(arr4);
            Assert.AreEqual(true, result1);
            int[] arr5 = new[] { 7, 8, 9, 1, 2, 5 };
            bool result2 = Program.IsContains5or6(arr5);
            Assert.AreEqual(true, result2);
            int[] arr7 = new[] { 6, 4, 7, 8, 9, 2 };
            bool result4 = Program.IsContains5or6(arr7);
            Assert.AreEqual(true, result4);
            int[] arr6 = new[] { 8, 9, 10, 1, 2 };
            bool result3 = Program.IsContains5or6(arr6);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void TestIsContains5and6()
        {
            int[] arr4 = new[] { 1, 2, 3, 4, 5, 6 };
            bool result1 = Program.IsContains5and6(arr4);
            Assert.AreEqual(true, result1);
            int[] arr5 = new[] { 7, 8, 9, 1, 2, 5 };
            bool result2 = Program.IsContains5and6(arr5);
            Assert.AreEqual(false, result2);
            int[] arr7 = new[] { 6, 4, 7, 8, 9, 2 };
            bool result4 = Program.IsContains5and6(arr7);
            Assert.AreEqual(false, result4);
            int[] arr6 = new[] { 8, 9, 10, 1, 2 };
            bool result3 = Program.IsContains5and6(arr6);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void TestCount5()
        {
            int[] arr4 = new[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program.Count5(arr4);
            Assert.AreEqual(1, result1);
            int[] arr5 = new[] { 7, 8, 9, 1, 2 };
            int result2 = Program.Count5(arr5);
            Assert.AreEqual(0, result2);
        }
        [TestMethod]
        public void TestCount5or6()
        {
            int[] arr4 = new[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program.Count5or6(arr4);
            Assert.AreEqual(2, result1);
            int[] arr5 = new[] { 7, 8, 9, 1, 2 };
            int result2 = Program.Count5or6(arr5);
            Assert.AreEqual(0, result2);
            int[] arr6 = new[] { 7, 8, 9, 1, 2, 5 };
            int result3 = Program.Count5or6(arr6);
            Assert.AreEqual(1, result3);
        }
        [TestMethod]
        public void TestSum()
        {
            int[] arr4 = new[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program.Sum(arr4);
            Assert.AreEqual(21, result1);
        }
    }
}
