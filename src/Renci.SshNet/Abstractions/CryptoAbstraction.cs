using System;
using System.Security.Cryptography;

namespace Renci.SshNet.Abstractions
{
    internal static class CryptoAbstraction
    {
        private static readonly RandomNumberGenerator Randomizer = CreateRandomNumberGenerator();

        /// <summary>
        /// Generates a <see cref="Byte"/> array of the specified length, and fills it with a
        /// cryptographically strong random sequence of values.
        /// </summary>
        /// <param name="length">The length of the array generate.</param>
        public static byte[] GenerateRandom(int length)
        {
            var random = new byte[length];
            GenerateRandom(random);
            return random;
        }

        /// <summary>
        /// Fills an array of bytes with a cryptographically strong random sequence of values.
        /// </summary>
        /// <param name="data">The array to fill with cryptographically strong random bytes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="data"/> is <c>null</c>.</exception>
        /// <remarks>
        /// The length of the byte array determines how many random bytes are produced.
        /// </remarks>
        public static void GenerateRandom(byte[] data)
        {
            Randomizer.GetBytes(data);
        }

        public static RandomNumberGenerator CreateRandomNumberGenerator()
        {
            return RandomNumberGenerator.Create();
        }

        public static MD5 CreateMD5()
        {
            return MD5.Create();
        }

        public static SHA1 CreateSHA1()
        {
            return SHA1.Create();
        }

        public static SHA256 CreateSHA256()
        {
            return SHA256.Create();
        }

        public static SHA384 CreateSHA384()
        {
            return SHA384.Create();
        }

        public static SHA512 CreateSHA512()
        {
            return SHA512.Create();
        }

        public static HMACMD5 CreateHMACMD5(byte[] key)
        {
            return new HMACMD5(key);
        }

        public static HMACSHA1 CreateHMACSHA1(byte[] key)
        {
            return new HMACSHA1(key);
        }

        public static HMACSHA256 CreateHMACSHA256(byte[] key)
        {
            return new HMACSHA256(key);
        }

        public static HMACSHA384 CreateHMACSHA384(byte[] key)
        {
            return new HMACSHA384(key);
        }

        public static HMACSHA512 CreateHMACSHA512(byte[] key)
        {
            return new HMACSHA512(key);
        }
    }
}
