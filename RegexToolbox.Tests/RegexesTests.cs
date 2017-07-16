using NUnit.Framework;

namespace RegexToolbox.Tests
{
    [TestFixture]
    public class RegexesTests
    {
        [Test]
        public void TestIpv4Address()
        {
            var validIpAddresses = new[]
            {
                "0.0.0.0",
                "10.0.0.1",
                "127.0.0.0",
                "255.255.255.0",
                "255.255.255.255"
            };

            var invalidIpAddresses = new[]
            {
                "0.0.0",
                "255.255.255.256",
                "elephant"
            };

            foreach (var validIpAddress in validIpAddresses)
            {
                var match = Regexes.Ipv4Address.Match(validIpAddress);
                Assert.IsTrue(match.Success);
                Assert.AreEqual(5, match.Groups.Count);
            }

            foreach (var invalidIpAddress in invalidIpAddresses)
            {
                var match = Regexes.Ipv4Address.Match(invalidIpAddress);
                Assert.IsFalse(match.Success);
            }
        }
    }
}