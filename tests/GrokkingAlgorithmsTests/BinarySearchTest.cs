using GrokkingAlgorithms;
using Xunit;

namespace GrokkingAlgorithmsTests
{
    public class BinarySearchTest
    {
        private readonly BinarySearch _binarySearch;

        public BinarySearchTest()
        {
            _binarySearch = new BinarySearch();
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 5, 6, 7, 9, 10, 14, 27, 43 }, 7, 4)]
        [InlineData(new int[] { 1, 2 }, 1, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5, 4)]
        public void BinarySearch_WhenAnOrdenedArrayAndATargetIsGiven_ShouldReturnIndexFounded(int[] values, int target, int expected)
        {
            //Given
            //When
            var result = _binarySearch.Search(values, target);

            //Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BinarySearch_WhenANonExistentTargetIsGiven_ShouldReturnMinusOneAsNotFound()
        {
            //Given
            var values = new int[] { 1, 3, 5, 7, 9 };
            var target = 4;

            //When
            var result = _binarySearch.Search(values, target);

            //Then
            Assert.Equal(-1, result);
        }
    }
}