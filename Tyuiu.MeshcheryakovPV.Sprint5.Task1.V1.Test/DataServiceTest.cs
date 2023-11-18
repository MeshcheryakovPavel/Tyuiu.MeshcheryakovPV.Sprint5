using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MeshcheryakovPV.Sprint5.Task1.V1.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\pavel\source\repos\Tyuiu.MeshcheryakovPV.Sprint5\Tyuiu.MeshcheryakovPV.Sprint5.Task1.V1\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
