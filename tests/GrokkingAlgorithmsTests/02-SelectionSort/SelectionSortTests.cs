using GrokkingAlgorithms;
using Xunit;

namespace GrokkingAlgorithmsTests
{
    public class SelectionSortTests
    {
        private readonly SelectionSort _selecttionSort;

        public SelectionSortTests()
        {
            _selecttionSort = new SelectionSort();
        }

        [Theory]
        [InlineData(new int[] { 3, 1, 2, 4, 9, 8, 7 }, new int[] { 1, 2, 3, 4, 7, 8, 9 })]
        [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        public void SelectionSort_WhenAnUnorderedArrayAreGiven_ShouldReturnArrayOrdered(int[] values, int[] expected)
        {
            //Given
            //When
            var result = _selecttionSort.Sort(values);

            //Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SelectionSort_WhenAnOrderedArrayIsGiven_ShouldReturnTheSameArray()
        {
            //Given
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //When
            var result = _selecttionSort.Sort(values);

            //Then
            Assert.Equal(values, result);
        }
    }
}