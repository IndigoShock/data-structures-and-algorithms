using System;
using Xunit;
using Sorting_Algorithms;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData((new int[] { 9, 4, 6, 10 }), (new int[] { 4, 6, 9, 10}))]
        [InlineData((new int[] { 8, 100, 7, 88 }), (new int[] { 7, 8, 88, 100 }))]
        [InlineData((new int[] { 55, 1000, 9001, 2 }), (new int[] { 2, 55, 1000, 9001 }))]


        public void CanSort(int[] value, int[] expected)
        {
            //Arrange
            int[] arrayUnsorted = value;

            //Act
            Program.InsertionSort(value);

            //Assert
            Assert.Equal(value, expected);
        }
    }
}
