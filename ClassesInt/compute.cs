﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInt
{
    class compute
    {
        public int sumNumbers(params int[] numbers)
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;

            }
            return sum;

        }


    }
}
