using System.Collections.Generic;

namespace GrokkingAlgorithms
{
    public class SelectionSort
    {
        public int[] Sort(int[] values)
        {
            var valuesList = new List<int>();
            valuesList.AddRange(values);
            var sortedList = new List<int>();

            for (var i = 0; i < values.Length; i++)
            {
                var smallest = GetSmallest(valuesList);
                sortedList.Add(valuesList[smallest]);

                valuesList.RemoveAt(smallest);
            }

            return sortedList.ToArray();
        }

        private int GetSmallest(List<int> values)
        {
            var smallest = values[0];
            var smallestIndex = 0;

            for (var i = 1; i < values.Count; i++)
            {
                if (values[i] < smallest)
                {
                    smallest = values[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}