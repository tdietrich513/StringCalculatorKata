namespace StringCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using NUnit.Framework;

    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Add_WithInput_ReturnsValue()
        {
            var result = StringCalculator.Add("");
            Assert.IsNotNull(result);
        }
    }
}
