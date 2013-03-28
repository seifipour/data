using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
namespace UnitTestProject1
{
    [TestClass]
    public class ExceptionTest
    {
        [TestMethod]
        public void If_NameOfUser_Is_Equal_Salam_Return_Exception()
        {
            var exception=new RaiseException();
            try
            {
                exception.NameOfUser("Salam");  
            }
            catch (Exception ex)
            {

                Assert.AreEqual(ex.Message, "Salam is not name");
            }
            
        }
    }
}
