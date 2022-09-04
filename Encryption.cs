using System.Security.Cryptography;
using System.Text;

namespace HeThongQLDVGiaoHangNhanh
{
    class Encryption
    {
        public static string MD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] arr = Encoding.UTF8.GetBytes(text);
            arr = md5.ComputeHash(arr);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in arr)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

    }
}
