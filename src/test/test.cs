using Xunit;
using InternTaskCSharp;

public class SumMinDigitsTests {
    [Fact]
    public void Test1()
    {
        int[] numbers = {4, 0, 3, 19, 492, -10, 1};
        int? result = Program.SumMinDigits(numbers);
        Assert.Equal(-10, result);
    }

    [Fact]
    public void Test2()
    {
        int[] numbers = {1};
        int? result = Program.SumMinDigits(numbers);
        Assert.Null(result);
    }

    [Fact]
    public void Test3()
    {
        int[] numbers = {1, 2, 3, 1};
        int? result = Program.SumMinDigits(numbers);
        Assert.Equal(2, result);
    }
}