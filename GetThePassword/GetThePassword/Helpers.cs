using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace Helpers
{
    namespace Extensions
    {
        public static class RandomNumberGeneratorExtensions
        {
            public static int Next(this RandomNumberGenerator randomNumberGenerator, int minValue, int maxValue)
            {
                maxValue -= 1;

                byte[] randomBytes = new byte[sizeof(int)];
                randomNumberGenerator.GetNonZeroBytes(randomBytes);
                int randomInt = BitConverter.ToInt32(randomBytes);

                return ((randomInt - minValue) % (maxValue - minValue + 1) + (maxValue - minValue + 1)) % (maxValue - minValue + 1) + minValue;
            }
        }

        public static class ReadOnlyCollectionExtensions
        {
            public static int GetNextClosest(this ReadOnlyCollection<int> readOnlyCollection, int number)
            {
                foreach (int item in readOnlyCollection)
                {
                    if (item > number)
                    {
                        return item;
                    }
                }

                return readOnlyCollection.Last();
            }

            public static int GetPreviousClosest(this ReadOnlyCollection<int> readOnlyCollection, int number)
            {
                foreach (int item in readOnlyCollection.Reverse())
                {
                    if (item < number)
                    {
                        return item;
                    }
                }

                return readOnlyCollection.First();
            }
        }
    }
}