using System;
using System.Collections;

namespace TabuSearch
{
    public static class Contants
    {
        static int tabuSize = 12;
        public static BitArray solution = new BitArray(tabuSize);
        public static int interactions = 1000;
        public static int listSize = 9;
        public static int nRestart = 10;
        public static bool repeatAll = true;
        public static Random random = new Random((int)DateTime.Now.Ticks);
    }
}