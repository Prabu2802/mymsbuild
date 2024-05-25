Using Microsoft.VisualStudio.TestTools.UnitTesting;
Using System.IO;
Using System;

Namespace HelloWorldTests
{
   [TestClass]
   Public Class UnitTest1
   {
      Private Const String Expected = "Hello World!";
      [TestMethod]
      Public void TestMethod1()
      {
         Using (var sw = New StringWriter())
         {
            Console.SetOut(sw);
            HelloWorld.Program.Main();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
         }
      }
   }
}