namespace CodalityTest;

public class Tests
{

#region Setup
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
    }

    [SetUp]
    public void Setup()
    {
    }
#endregion


    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

#region Teardown
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
    }

    [TearDown]
    public void TearDown()
    {
    }
#endregion
}