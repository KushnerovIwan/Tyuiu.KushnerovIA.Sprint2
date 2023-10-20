using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KushnerovIA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;
            if (y <= 0.5 && y >= 0 && y <= Math.Sin(x) && x >= 0 && x <= Math.PI)
            {
                res = true;
            }
            return res;
                
               

            
        }
    }
}
