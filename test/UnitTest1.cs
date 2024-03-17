using ConvertAgeToDays;

namespace test;

[TestClass]
public class UnitTest
{
    [TestMethod]
    public void calcAgeTest()
    {
        Assert.AreEqual(0, AgeConverter.calcAge(-1));
        Assert.AreEqual(0, AgeConverter.calcAge(0));
        Assert.AreEqual(365, AgeConverter.calcAge(1));
        Assert.AreEqual(730, AgeConverter.calcAge(2));
        Assert.AreEqual(1095, AgeConverter.calcAge(3));
    }
}