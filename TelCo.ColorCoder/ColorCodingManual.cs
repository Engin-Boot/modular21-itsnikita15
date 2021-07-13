using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class ColorCodingManual
    {

        public static void GetManual()
        {

            int pairNum = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.WriteLine("Colors: major{0} - minor{1}, Pair Number: {2}\n", Program.colorMapMajor[i], Program.colorMapMinor[j], pairNum);
                    pairNum++;
                }
            }

        }

    }
}