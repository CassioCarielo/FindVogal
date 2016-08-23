using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using TesteCassioCarielo;

namespace UnitTestCassioCarielo
{
    [TestClass]
    public class TestFindVogal
    {
        [TestMethod]
        public void TestVogalValid()
        {
            StringStream stream = new StringStream("aAbBABac");
            FindVogal findVogal = new FindVogal();
            char resultado;
            try
            {
                resultado = findVogal.firstChar(stream);
            }
            catch (System.Exception)
            {
                resultado = ' ';
            }
            Assert.IsTrue(resultado != ' ');
        }

        [TestMethod]
        public void TestVogalInvalid()
        {
            StringStream stream = new StringStream("aaaaaaaaa");
            FindVogal findVogal = new FindVogal();
            char resultado;
            try
            {
                resultado = findVogal.firstChar(stream);
            }
            catch (System.Exception)
            {
                resultado = ' ';
            }
            Assert.IsTrue(resultado == ' ');
        }
    }
}
