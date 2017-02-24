using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveDuplicatesFromSortedArray;

namespace Tests
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void Test_1_is_1()
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
        public void Test_1_1_is_1()
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
        public void Test_1_2_2_4_is_3()
        {
            // Arrange
            var nums = new int[] { 1, 2, 2, 4 };
            var expected = 3;

            // Act
            var actual = Solution.RemoveDuplicates(nums);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
