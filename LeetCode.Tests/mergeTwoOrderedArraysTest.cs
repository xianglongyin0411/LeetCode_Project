// filepath: c:\Users\SESA812587\Desktop\LeetCode\arrays or strings\mergeTwoOrderedArraysTest.cs
using Xunit;
using arraysAndstrings;

namespace arraysAndstrings.Tests
{
    public class mergeTwoOrderedArraysTest
    {
        [Fact]
        public void Test_Merge_TwoEmptyArrays()
        {
            // Arrange
            var solution = new mergeTwoOrderedArrays();
            int[] nums1 = { };
            int m = 0;
            int[] nums2 = { };
            int n = 0;

            // Act
            solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.Equal(new int[] { }, nums1);
        }

        [Fact]
        public void Test_Merge_AllNums1SmallerThanNums2()
        {
            // Arrange
            var solution = new mergeTwoOrderedArrays();
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 4, 5, 6 };
            int n = 3;

            // Act
            solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6 }, nums1);
        }

        [Fact]
        public void Test_Merge_AllNums1LargerThanNums2()
        {
            // Arrange
            var solution = new mergeTwoOrderedArrays();
            int[] nums1 = { 4, 5, 6, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 1, 2, 3 };
            int n = 3;

            // Act
            solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6 }, nums1);
        }

        [Fact]
        public void Test_Merge_WithDuplicateElements()
        {
            // Arrange
            var solution = new mergeTwoOrderedArrays();
            int[] nums1 = { 1, 2, 2, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 2, 3 };
            int n = 3;

            // Act
            solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.Equal(new int[] { 1, 2, 2, 2, 2, 3 }, nums1);
        }
    }
}
