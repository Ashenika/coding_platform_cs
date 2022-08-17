using Microsoft.VisualStudio.TestTools.UnitTesting;
using template_cs;

namespace template_cs_test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
       
            int result = Calculator.Add(1, 2);

            Assert.AreEqual(3, result);
            
        }
    }
}
