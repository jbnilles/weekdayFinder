using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
namespace WeekdayFinder.Tests
{
    [TestClass]
    public class WeekdayFinder
    {
        [TestMethod]
        public void FindDay_FindsDayOfWeek_String()
        {

          Assert.AreEqual("Friday", Day.FindDay("9", "25", "2020") );
        }
    }
}