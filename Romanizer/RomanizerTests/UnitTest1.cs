using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanizerLib;

namespace RomanizerTests
{
    [TestClass]
    public class UnitTest1
    {
        private Romanizer _romanizer;
        //from CSV
        private IEnumerable<KeyValuePair<int, string>> RefData;


        [TestMethod]
        public void IntToRoman1_3999()
        {
            for (int i = 1; i < 4000; i++)
            {
                Assert.AreEqual(RefData.FirstOrDefault(x => x.Key == i).Value, _romanizer.Translate(i));
            }
        }

        #region Setup
        [TestInitialize]
        public void Setup()
        {
            RefData = RomanizerLib.Helpers.GetReferenceData();
            _romanizer = new Romanizer();
        }
        #endregion Setup


    }
}
