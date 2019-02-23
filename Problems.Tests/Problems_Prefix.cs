using NUnit.Framework;
using Problems;


namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void multipleTestMethods()
        {
            string output = Program.Prefix("hello");
            Assert.That(output, Is.EqualTo("5,1:hello"));
                
            output = Program.Prefix("");
            Assert.That(output, Is.EqualTo("0,0:"));
        
     
            output = Program.Prefix("what ... did you say?? ");
            Assert.That(output, Is.EqualTo("23,5:what ... did you say?? "));

            output = Program.Prefix("    one    ");
            Assert.That(output, Is.EqualTo("11,1:    one    "));

            output = Program.Prefix("There are five words here ");
            Assert.That(output, Is.EqualTo("26,5:There are five words here "));

            output = Program.Prefix("     ");
            Assert.That(output, Is.EqualTo("5,0:     "));
            
        }



    }
}