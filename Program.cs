using System;
using System.Security.Cryptography;
using System.Text;

namespace LinkHasher
{
    class Program
    {   
        static void Main(string[] args)
        {
            string phoneNumber = "79054991616";
            Hasher phoneHash = new Hasher();
            string result = phoneHash.GetStringToHash(phoneNumber);

            Console.WriteLine(result);

            string cropResult = phoneHash.GetFirstThreeBytes(result);
            Console.WriteLine(cropResult);
        }


    }
}
