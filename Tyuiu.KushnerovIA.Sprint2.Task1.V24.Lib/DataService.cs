using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KushnerovIA.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        { //a = 325, b = 325, c = 242, d = 324
            bool[] res = new bool[6];

            res[0] = (a == b) | (c != d); //t
            res[1] = (a < b) & (c > d); //f
            res[2] = (a <= b) || (c >= d); //t
            res[3] = (a + 17 == b) && (c < d); //f
            res[4] = !(res[3]); //t
            res[5] = (a < b) ^ (c > d); //f

            return res;
        }
    }
}
