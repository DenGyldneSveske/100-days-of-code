using ConvertAgeToDays;
using FindingNemo;
using BarbecueSkewers;
using JohnnyProgress;
using Socks;
using NextPrimeNumber;

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

    [TestMethod]
    public void findNemoTest()
    {
        Assert.AreEqual("I found Nemo at 1!", NemoFinder.findNemo("Nemo is me"));
        Assert.AreEqual("I found Nemo at 3!", NemoFinder.findNemo("I am Nemo"));
        Assert.AreEqual("I can't find Nemo :(", NemoFinder.findNemo("I am a fish"));
    }

    [TestMethod]
    public void calculateSkewersTest()
    {
        CollectionAssert.AreEqual(new int[] { 2, 3 }, Skewers.calculateSkewers(new string[] { "--oooo-ooo--",
                                                                                    "--xx--x--xx--",
                                                                                    "--o---o--oo--",
                                                                                    "--xx--x--ox--",
                                                                                    "--xx--x--ox--" }));
        CollectionAssert.AreEqual(new int[] { 3, 2 }, Skewers.calculateSkewers(new string[] { "--oooo-ooo--",
                                                                                    "--xxxxxxxx--",
                                                                                    "--o---",
                                                                                    "-o-----o---x--",
                                                                                    "--o---o-----" }));
    }

    [TestMethod]
    public void isJohnnyMakingProgressTest()
    {
        Assert.AreEqual(2, makingProgress.isJohnnyMakingProgress([3, 4, 1, 2]));
        Assert.AreEqual(3, makingProgress.isJohnnyMakingProgress([10, 11, 12, 9, 10]));
        Assert.AreEqual(1, makingProgress.isJohnnyMakingProgress([6, 5, 4, 3, 2, 9]));
        Assert.AreEqual(0, makingProgress.isJohnnyMakingProgress([9, 9]));
    }

    [TestMethod]
    public void pairsOfSocksTest()
    {
        Assert.AreEqual(1, SockPairs.sockPairs("AA"));
        Assert.AreEqual(2, SockPairs.sockPairs("ABABC"));
        Assert.AreEqual(4, SockPairs.sockPairs("CABBACCC"));
    }

    [TestMethod]
    public void findNextPrimeTest()
    {
        Assert.AreEqual(13, NextPrime.findNextPrime(12));
        Assert.AreEqual(29, NextPrime.findNextPrime(24));
        Assert.AreEqual(11, NextPrime.findNextPrime(11));
    }
}