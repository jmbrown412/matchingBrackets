using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BracketParser.Lib.Tests
{
    [TestClass]
    public class BrackerParserTests
    {
        private BracketParser _sut = null;

        [TestInitialize]
        public void TestInit()
        {
            _sut = new BracketParser();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _sut = null;
        }

        [DataRow("{}", true)]
        [DataRow("}{", false)]
        [DataRow("{{}", false)]
        [DataRow("{}{}", true)]
        [DataRow("}", false)]
        [DataRow("{", false)]
        [DataRow("}}{}", false)]
        [DataRow("{ \"Id\": 1, \"Name\": \"Test\" }", true)]
        [DataRow("\"\"", true)]
        [DataRow("", true)] 
        [DataTestMethod]
        public void TestBracketParser(string test, bool expected)
        {
            Assert.AreEqual(_sut.HasMatchingBrackets(test), expected);
        }
    }
}
