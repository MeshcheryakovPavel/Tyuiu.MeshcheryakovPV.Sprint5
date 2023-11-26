using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Tyuiu.MeshcheryakovPV.Sprint5.Task6.V5.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint5.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\pavel\source\repos\Tyuiu.MeshcheryakovPV.Sprint5\Tyuiu.MeshcheryakovPV.Sprint5.Task6.V5\bin\Debug\InPutDataFileTask6V5.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\pavel\source\repos\Tyuiu.MeshcheryakovPV.Sprint5\Tyuiu.MeshcheryakovPV.Sprint5.Task6.V5\bin\Debug\InPutDataFileTask6V5.txt";
            int wait = 5;
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }

    }
}
