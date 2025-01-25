using JetBrains.Annotations;
using Xunit;

namespace Money.Tests;

[TestSubject(typeof(Dollar))]
public class DollarTest
{

    [Fact]
    public void TestMultiplication()
    {
        var five = new Dollar(5);
        five.Times(2);
        Assert.Equal(10, five.Amount);
    }
}