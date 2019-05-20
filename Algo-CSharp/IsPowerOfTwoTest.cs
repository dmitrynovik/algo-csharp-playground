using FluentAssertions;
using Xunit;

namespace Algo_CSharp
{
    public class IsNumberOfTwoTest
    {
        [Fact] public void Two_Is_A_Power_Of_Two() => 2.IsPowerOfTwo().Should().Be(true);

        [Fact] public void One_Is_A_Power_Of_Two() => 1.IsPowerOfTwo().Should().Be(true);

        [Fact] public void Four_Is_A_Power_Of_Two() => 4.IsPowerOfTwo().Should().Be(true);

        [Fact] public void Five_IsNot_A_Power_Of_Two() => 5.IsPowerOfTwo().Should().Be(false);

        [Fact]  public void Zero_IsNot_A_Power_Of_Two() => 0.IsPowerOfTwo().Should().Be(false);

        [Fact] public void MinusTwo_IsNot_A_Power_Of_Two() => (-2).IsPowerOfTwo().Should().Be(false);
    }
}
