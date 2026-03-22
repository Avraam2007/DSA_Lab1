using DSA_Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DSA_Lab1Tests
{
    [TestClass]
    public class DsaTests
    {
        //[TestInitialize()]
        //public void Startup() {
        //    sw = new Stopwatch();
        //}

        //[TestCleanup()]
        //public void Cleanup() {
        //    Console.WriteLine($"Time spent: {sw.Elapsed}");
        //    sw = null;
        //}

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_WithValidTypes_FindIndex() {
            int expected = 2;
            int[] array = { 1, 6, 34, 54, 65, 71, 80, 100, 101 };
            BinarySearchClass bs = new BinarySearchClass();

            int actual = bs.BinarySearch(array, 34);

            Assert.AreEqual(expected, actual, "Index not found correctly");
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_WithInvalidTypes_FindIndex() {
            int expected = -1;
            int[] array = { 1, 6, 34, 54, 65, 71, 80, 100, 101 };
            DSA_Lab1.BinarySearchClass bs = new DSA_Lab1.BinarySearchClass();

            int actual = bs.BinarySearch(array, 1488);
            Assert.AreEqual(expected, actual, "Index not found correctly");
        }

        [TestMethod]
        [TestCategory("BinarySearch")]
        public void BinarySearch_WithEmptyArray_FindIndex() {
            int expected = -1;
            int[] array = { };
            DSA_Lab1.BinarySearchClass bs = new DSA_Lab1.BinarySearchClass();

            int actual = bs.BinarySearch(array, 1488);
            Assert.AreEqual(expected, actual, "Index not found correctly");
        }

        [TestMethod]
        [TestCategory("MergeSort")]
        public void MergeSort_WithValidTypes_SortArray() {
            double[] expected = { 1, 2, 5, 7, 12, 23, 45, 543 };
            DSA_Lab1.MergeSortClass ms = new DSA_Lab1.MergeSortClass();
            double[] val = { 12, 543, 23, 45, 1, 7, 2, 5 };

            double[] actual = ms.MergeSort(val);
            CollectionAssert.AreEqual(expected, actual, "Array not sorted correctly");
        }

        [TestMethod]
        [TestCategory("SelectionSort")]
        public void SelectionSort_WithValidTypes_SortArray() {
            double[] expected = { 1, 2, 5, 7, 12, 23, 45, 543 };
            SelectionSortClass ss = new SelectionSortClass();
            double[] val = { 12, 543, 23, 45, 1, 7, 2, 5 };

            double[] actual = ss.SelectionSort(val);
            CollectionAssert.AreEqual(expected, actual, "Array not sorted correctly");
        }

        [TestMethod]
        [TestCategory("CountingSort")]
        public void CountingSort_WithValidTypes_SortArray() {
            int[] expected = { 0, 0, 2, 3, 3, 3, 4, 5 };
            CountingSortClass cs = new CountingSortClass();
            int[] val = { 4, 5, 3, 0, 2, 3, 0, 3 };

            int[] actual = cs.CountingSort(val);
            CollectionAssert.AreEqual(expected, actual, "Array not sorted correctly");
        }

        [TestMethod]
        [TestCategory("EuclidAlgorythm")]
        public void EuclidAlgorythm_WithoutRelativeDivider_Math() {
            int first = 5;
            int second = 6;
            int expected = 1;
            EuclidAlgorytmClass ea = new EuclidAlgorytmClass();

            int actual = ea.FindGCD(first, second);
            Assert.AreEqual(expected, actual, "Divider doesn`t found correctly");
        }

        [TestMethod]
        [TestCategory("EuclidAlgorythm")]
        public void EuclidAlgorythm_WithRelativeDivider_Math() {
            int first = 26;
            int second = 12;
            int expected = 2;
            EuclidAlgorytmClass ea = new EuclidAlgorytmClass();

            int actual = ea.FindGCD(first, second);
            Assert.AreEqual(expected, actual, "Divider doesn`t found correctly");
        }

        [TestMethod]
        [TestCategory("EuclidAlgorythm")]
        public void EuclidAlgorythm_WithInvalidTypes_Math() {
            int first = 26;
            int second = -56;
            int expected = -1;
            EuclidAlgorytmClass ea = new EuclidAlgorytmClass();

            int actual = ea.FindGCD(first, second);
            Assert.AreEqual(expected, actual, "Divider doesn`t found correctly");
        }


        [TestMethod]
        [TestCategory("EratosthenesSieve")]
        public void EratosthenesSieve_WithValidTypes_Math() {
            List<int> expected = new List<int>() { 2,3,5,7,11,13,17,19,23,29,31,37,41,43,47 };
            EratosthenesSieveClass es = new EratosthenesSieveClass();

            List<int> actual = es.getResult(50);
            CollectionAssert.AreEqual(expected, actual, "Sieving not worked correctly");
        }

        [TestMethod]
        [TestCategory("FastPow")]
        public void FastPow_WithZeroExponent_Math() {
            double x = 16;
            double y = 0;
            double expected = 1;
            FastPowClass fp = new FastPowClass();

            double actual = fp.fastPow(x,y);
            Assert.AreEqual(expected, actual, "Exponentiation not worked correctly");
        }

        [TestMethod]
        [TestCategory("FastPow")]
        public void FastPow_WithPositiveNumbers_Math() {
            double x = 2;
            double y = 3;
            double expected = 8;
            FastPowClass fp = new FastPowClass();

            double actual = fp.fastPow(x, y);
            Assert.AreEqual(expected, actual, "Exponentiation not worked correctly");
        }

        [TestMethod]
        [TestCategory("FastPow")]
        public void FastPow_WithNegativeExponent_Math() {
            double x = 2;
            double y = -3;
            double expected = 0.125;
            FastPowClass fp = new FastPowClass();

            double actual = fp.fastPow(x, y);
            Assert.AreEqual(expected, actual, "Exponentiation not worked correctly");
        }

        [TestMethod]
        [TestCategory("FastPow")]
        public void FastPow_WithNegativeBody_Math() {
            double x = -2;
            double y = 3;
            double expected = -8;
            FastPowClass fp = new FastPowClass();

            double actual = fp.fastPow(x, y);
            Assert.AreEqual(expected, actual, "Exponentiation not worked correctly");
        }

        [TestMethod]
        [TestCategory("FastPow")]
        public void FastPow_WithOneBody_Math() {
            double x = 1;
            double y = 160;
            double expected = 1;
            FastPowClass fp = new FastPowClass();

            double actual = fp.fastPow(x, y); 
            Assert.AreEqual(expected, actual, "Exponentiation not worked correctly");
        }

        [TestMethod]
        [TestCategory("FastPow")]
        public void FastPow_WithZeroBody_Math() {
            double x = 0;
            double y = 56;
            double expected = 0;
            FastPowClass fp = new FastPowClass();

            double actual = fp.fastPow(x, y);
            Assert.AreEqual(expected, actual, "Exponentiation not worked correctly");
        }

        [TestMethod]
        [TestCategory("FastPow")]
        public void FastPow_WithZeroValues_Math() {
            double x = 0;
            double y = 0;
            double expected = 1;
            FastPowClass fp = new FastPowClass();

            double actual = fp.fastPow(x, y);
            Assert.AreEqual(expected, actual, "Exponentiation not worked correctly");
        }

        [TestMethod]
        [TestCategory("BasicMatrixMultiplying")]
        public void BasicMatrixMultiplying_WithRectangularMatrixes_Matrix() {
            int[,] a = { { 1, 2, 2 }, { 3, 1, 1 } };
            int[,] b = { { 4, 2 }, { 3, 1 }, { 1, 5 } };
            MatrixMultiplyingClass ml = new MatrixMultiplyingClass();
            int[,] expected = { { 12, 14 }, { 16, 12 } };

            int[,] actual = ml.BasicMultiplying(a, b);
            CollectionAssert.AreEqual(expected, actual, "Matrix multiplying not worked correctly");
        }

        [TestMethod]
        [TestCategory("BasicMatrixMultiplying")]
        public void BasicMatrixMultiplying_WithSquareMatrixes_Matrix() {
            int[,] a = { { 5,2 }, { 3, 1 } };
            int[,] b = { { 4, 6 }, { 5, 2 } };
            MatrixMultiplyingClass ml = new MatrixMultiplyingClass();
            int[,] expected = { { 30, 34 }, { 17, 20 } };

            int[,] actual = ml.BasicMultiplying(a, b);
            CollectionAssert.AreEqual(expected, actual, "Matrix multiplying not worked correctly");
        }

        [TestMethod]
        [TestCategory("Kadane")]
        public void Kadane_WithValidValues_Arrays() {
            int[] arr = { -3, 4, 9, -2, -5, 8, -3 };
            KadaneClass kadane = new KadaneClass();
            int expected = 14;

            int actual = kadane.Kadane(arr);
            Assert.AreEqual(expected, actual, "Matrix multiplying not worked correctly");
        }
    }
}
