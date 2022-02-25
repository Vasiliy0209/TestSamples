using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSum10and5()
        {
            double result = MyClassLibrary.MyCalc.Sum(10, 5);

            //Сравниваем ожидаемое и фактическое значение
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestDivide10on5()
        {
            double result = MyClassLibrary.MyCalc.Divide(10,5);

            //Сравниваем ожидаемое и фактическое значение
            Assert.AreEqual(2,result);
        }

        [TestMethod]
        public void TestDivide10on0()
        {
            try
            {
                double result = MyClassLibrary.MyCalc.Divide(10, 0);
            }catch(MyClassLibrary.MyDivideException ex)
            {
                return;
            }catch(Exception ex)
            {
                Assert.Fail("Сгенерировано неизвестное исключение");
            }
            Assert.Fail("Исключение не сгенерировано");            
        }
    }
}
