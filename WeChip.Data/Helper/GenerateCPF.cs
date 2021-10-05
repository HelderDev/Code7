using System;
using System.Collections.Generic;
using System.Text;

namespace WeChip.Data.Helper
{
    public static class GenerateCPF
    {
        public static string Generate()
        {
            int sum = 0, mod = 0;
            int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string seed = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                sum += int.Parse(seed[i].ToString()) * mult1[i];

            mod = sum % 11;
            if (mod < 2)
                mod = 0;
            else
                mod = 11 - mod;

            seed = seed + mod;
            sum = 0;

            for (int i = 0; i < 10; i++)
                sum += int.Parse(seed[i].ToString()) * mult2[i];

            mod = sum % 11;

            if (mod < 2)
                mod = 0;
            else
                mod = 11 - mod;

            seed = seed + mod;
            return Convert.ToUInt64(seed).ToString(@"000\.000\.000\-00");
        }
    }
}
