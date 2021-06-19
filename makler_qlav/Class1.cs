using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makler_qlav
{
    class Class1
    {
        public static bool Otvet;
        public static bool Otv;

        public static void IN(bool x)
        {
            Otv = x;
        }

        public static bool OUT(int y) =>
            Otv;

        public static void Prinal(bool x)
        {
            Otvet = x;
        }

        public static bool Vernul(int y) =>
            Otvet;
    }

}

