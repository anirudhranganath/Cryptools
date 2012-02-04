using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace crpytoolscs
{
    class md5con
    {
        public static string Encodemd5(string orig)
        {
            Byte[] origbytes;
            Byte[] encodedbytes;
            MD5 md5;
            md5 = new MD5CryptoServiceProvider();
            origbytes = ASCIIEncoding.Default.GetBytes(orig);
            encodedbytes = md5.ComputeHash(origbytes);
            return BitConverter.ToString(encodedbytes);
        }
    }
}
