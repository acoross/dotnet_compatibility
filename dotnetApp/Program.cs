using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SharedProject1.SharedClass sc = new SharedProject1.SharedClass();
            sc.data = 10;

            CrossPlatformLib.CrossPlatformLib cpl = new CrossPlatformLib.CrossPlatformLib();
            
        }
    }
}
