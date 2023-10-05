using System;

namespace UnitTestBDCL1
{
    class HamKT
    {
        public String Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return ("");
                else if ((b + c) <= a)
                    return ("");
                else if ((a + c) <= b)
                    return ("");
                else return ("Scalene");
            else if (match == 1)
                if ((a + c) <= b)
                    return ("");
                else return ("Isosceles");
            else if (match == 2)
                if ((a + c) <= b)
                    return ("");
                else return ("Isosceles");
            else if (match == 3)
                if ((b + c) <= a)
                    return ("");
                else return ("Isosceles");
            else return ("Equilateral");

        }

    }
}
