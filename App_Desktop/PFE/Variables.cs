using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE
{
    static class Variables
    {
        public static string password = "";
        public static string cryptage(string password)
        {
            char[] chars = password.ToCharArray();
            for(int i= 0; i < chars.Length;i++)
            {
                int x =  Convert.ToByte(chars[i])+2;
                chars[i] = (char) x;
            }
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
