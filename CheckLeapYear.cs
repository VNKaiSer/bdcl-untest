﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestBDCL1
{
    class CheckLeapYear
    {
        public bool IsLeapYear(int n)
        {
            if ((n % 4 == 0) || (n % 100 == 0 && n % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
