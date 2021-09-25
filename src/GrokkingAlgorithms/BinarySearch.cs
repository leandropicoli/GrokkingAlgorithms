namespace GrokkingAlgorithms
{
    public class BinarySearch
    {
        public int Search(int[] values, int target)
        {
            var low = 0;
            var high = values.Length - 1;

            while (low <= high)
            {
                var mid = (low + high) / 2;
                var value = values[mid];

                if (value == target) return mid;

                if (value > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}