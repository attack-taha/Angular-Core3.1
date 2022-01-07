﻿using System.Security.Cryptography;
using System.Text;

namespace BWC.Utilities.Hashing
{
    public static class SHA
    {
        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
    public class AppSettings
    {
        public string Secret { get; set; }
        public string Issure { get; set; }
        public string ValidAudience { get; set; }
    }
}
