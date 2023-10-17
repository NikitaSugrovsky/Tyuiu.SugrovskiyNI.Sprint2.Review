using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint2.TaskReview.V14.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint2.TaskReview.V14.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.5;

           bool res = ds.CheckDotInShadedArea(x, y);
           bool wait = true;

           Assert.AreEqual(wait, res);
        }
    }
}
