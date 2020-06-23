﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MGA.Utility
{
  public class GenrateRandonPassword
    {

      public static string GetUniqueKey(int maxSize)
      {
          char[] chars = new char[62];
          chars =
          "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
          byte[] data = new byte[1];
          using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
          {
              crypto.GetNonZeroBytes(data);
              data = new byte[maxSize];
              crypto.GetNonZeroBytes(data);
          }
          StringBuilder result = new StringBuilder(maxSize);
          foreach (byte b in data)
          {
              result.Append(chars[b % (chars.Length)]);
          }
          return result.ToString();
      }
        public static string GetCapitalUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
    }
}
