using CS_1410_Final_Proj_Lib;
using NUnit.Framework;

namespace Final_Proj_Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BuildAPerson()
    {
        Person User = new Person("Parker", "Swenson", 4560, 1);
        Person OtherUser = new Person("Parker", "Swenson", 4560, 1);

        Assert.AreEqual(OtherUser, User);
    }
}