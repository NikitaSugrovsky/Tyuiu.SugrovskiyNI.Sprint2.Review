using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SugrovskiyNI.Sprint2.TaskReview.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = (x * x + y * y <= 1) && ((y >= 0 && y <= x) || (y <= 0 && y >= -x));

            return res;
        }
       }
    }
