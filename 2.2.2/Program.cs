﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            //boxed

            object o = a;

            //Unboxing
            int c = (int)o;
        }
    }
}