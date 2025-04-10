using Xunit;
using LeetCode;

namespace LeetCode.Tests
{
    public class removeTheElementTest
    {
        [Fact]
        public void Test_RemoveElement_NoElementsToRemove()
        {
            // Arrange
            var solution = new removeTheElement();
            int[] nums = { 1, 2, 3, 4 };
            int val = 5;

            // Act
            int result = solution.RemoveElement(nums, val);

            // Assert
            Assert.Equal(4, result);
            Assert.Equal(new int[] { 1, 2, 3, 4 }, nums[..result]);
        }

        [Fact]
        public void Test_RemoveElement_AllElementsToRemove()
        {
            // Arrange
            var solution = new removeTheElement();
            int[] nums = { 3, 3, 3, 3 };
            int val = 3;

            // Act
            int result = solution.RemoveElement(nums, val);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_RemoveElement_SomeElementsToRemove()
        {
            // Arrange
            var solution = new removeTheElement();
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;

            // Act
            int result = solution.RemoveElement(nums, val);

            // Assert
            Assert.Equal(2, result);
            Assert.Equal(new int[] { 2, 2 }, nums[..result]);
        }

        [Fact]
        public void Test_RemoveElement_EmptyArray()
        {
            // Arrange
            var solution = new removeTheElement();
            int[] nums = { };
            int val = 1;

            // Act
            int result = solution.RemoveElement(nums, val);

            // Assert
            Assert.Equal(0, result);
        }
    }
}