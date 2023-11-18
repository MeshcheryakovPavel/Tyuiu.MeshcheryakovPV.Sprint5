using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MeshcheryakovPV.Sprint5.Task0.V8.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint5.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\pavel\source\repos\Tyuiu.MeshcheryakovPV.Sprint5\Tyuiu.MeshcheryakovPV.Sprint5.Task0.V8\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
