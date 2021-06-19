using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace makler_qlav
{
    class Class2
    {
        public static int x;
        public static string Un;

        public static void PR1(string UN)
        {
            Un = UN;
        }

        public static string PR2() =>
            Un;

        public static void Prinal(int X)
        {
            x = X;
        }

        public static int Vernul() =>
            x;
    }
}

    

