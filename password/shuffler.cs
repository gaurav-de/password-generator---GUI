﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace custom_needs
{
    internal class shuffler
    {
        public static String string_shuffler(String need_to_shouffled)
        { 
            Char temp_one;
            List<string> list = new List<string>();
            int nameLength = need_to_shouffled.Length;

            while(nameLength > 0)
            {
                temp_one = need_to_shouffled[(nameLength - 1)];
                list.Add(temp_one.ToString());
                nameLength--;
            }

            var shuffledcards = list.OrderBy(a => Guid.NewGuid()).ToList();
            string str = String.Join("", shuffledcards);
            return str;
        }
    }
}
