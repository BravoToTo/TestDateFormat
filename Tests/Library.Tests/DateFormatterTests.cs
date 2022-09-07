namespace Library.Tests;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestFormat()
    {
        string testDate = "10-11-1997";
        string expectedDate = "1997-11-10";
        Assert.AreEqual(expectedDate, TestDateFormat.DateFormatter.ChangeFormat(testDate));
    }
}