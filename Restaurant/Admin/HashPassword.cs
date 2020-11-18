﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    class HashPassword
    {
        // fungsi untuk melakukan Hash dengan menggunakan SHA256
        public static string SHA256Hash(string rawData)
        {
            string result = "";
            try
            {
                using (SHA256 sha = SHA256.Create())
                {
                    byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in bytes)
                    {
                        sb.Append(item.ToString("X2"));
                    }
                    result = sb.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
