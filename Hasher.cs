using System;
using System.Security.Cryptography;
using System.Text;

namespace LinkHasher
{
    public class Hasher 
    {
        public string GetStringToHash(string inputData)
        {
            byte[] byteArrayPhoneNumber = Encoding.UTF8.GetBytes(inputData);

            SHA256 sha256Hash = SHA256.Create();
            HashAlgorithm hashAlgorithm = sha256Hash;
            byte[] phoneHashArray = hashAlgorithm.ComputeHash(byteArrayPhoneNumber);
            
            var sBuilder = new StringBuilder();
            for (int i = 0; i < phoneHashArray.Length; i++)
            {
                sBuilder.Append(phoneHashArray[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public string GetFirstThreeBytes(string inputData)
        {
            return inputData.Remove(6);
        }
    }
}
