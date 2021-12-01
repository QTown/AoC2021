using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021
{
    public class Common
    {

        public static string[] ReadFile(string filename)
        {
            return File.ReadAllLines(@$"Inputs/{filename}");
        }

        public static string ReadRaw(string filename)
        {
            return File.ReadAllText(@$"Inputs/{filename}");
        }
    }
}
