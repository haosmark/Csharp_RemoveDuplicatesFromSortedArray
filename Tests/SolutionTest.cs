using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveDuplicatesFromSortedArray;

namespace Tests
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void Test_1_is_len_1()
        {
            // Arrange
            var nums = new int[] { 1 };
            var expected = 1;

            // Act
            var actual = Solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_1_1_is_len_1()
        {
            // Arrange
            var nums = new int[] { 1, 1 };
            var expected = 1;

            // Act
            var actual = Solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_1_2_2_4_is_len_3()
        {
            // Arrange
            var nums = new int[] { 1, 2, 2, 4 };
            var expected = 3;

            // Act
            var actual = Solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_1_2_2_4_is_nums_1_2_4()
        {
            // Arrange
            var nums = new int[] { 1, 2, 2, 4 };
            var expected = new int[] { 1, 2, 4 };

            // Act
            Solution.RemoveDuplicates(nums);
            int[] actual = new int[3];
            Array.Copy(nums, actual, 3);
            

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_1_2_2_2_is_len_2()
        {
            // Arrange
            var nums = new int[] { 1, 2, 2, 2 };
            var expected = 2;

            // Act
            var actual = Solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_1_2_2_2_is_nums_1_2()
        {
            // Arrange
            var nums = new int[] { 1, 2, 2, 2 };
            var expected = new int[] { 1, 2 };

            // Act
            Solution.RemoveDuplicates(nums);
            int[] actual = new int[2];
            Array.Copy(nums, actual, 2);


            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
