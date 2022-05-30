using System.Security.Cryptography;

namespace Helpers
{
    namespace Extensions
    {
        public static class Extensions
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
    }
}