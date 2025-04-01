﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Util
    {
        public static void Print(string context, ConsoleColor textColor = ConsoleColor.White, int delay = 0) //ms임 1000=1초
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
    }
}
