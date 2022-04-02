using System;

namespace lab2_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1-declare 10 variables with ten different data types
            string myName = "Chukwwma Nnaemeka Elvis";
            int myInt = -24;
            uint myAge = 24;
            double myHeight_in_metres = 1.9;
            char myletter = 'D';
            bool I_love_backend = true;
            long myLong = -100000000000000000;
            ulong myUlong = 10000000000000000;
            float myfloat = 3.12121212121f;
            decimal myDecimal = 1.23456789m;

            // Q2-show examples of impilict and explicit conversion
            // implicit
            long a = myAge;
            double c = myfloat;
            // explicit
            int b = (int)myHeight_in_metres;
            float e =(float)myDecimal;
            











        }
    }
}
