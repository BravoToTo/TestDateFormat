namespace Library.Tests;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestGoodFormat()
    {
        string testDate = "10/11/1997";
        string expected = "1997-11-10";
        Assert.AreEqual(expected, TestDateFormat.DateFormatter.ChangeFormat(testDate));
    }

    [Test]
    public void TestBadFormat()
    {
        string testDate = "10-11-1997";
        string expected = "Error, ingrese el formato correcto.";
        Assert.AreEqual(expected, TestDateFormat.DateFormatter.ChangeFormat(testDate));
    }

    [Test]
    public void TestEmpty()
    {
        string testDate = "";
        string expected = "Error, ingrese el formato correcto.";
        Assert.AreEqual(expected, TestDateFormat.DateFormatter.ChangeFormat(testDate));
    }
}