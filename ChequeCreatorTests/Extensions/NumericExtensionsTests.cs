using System;

using ChequeCreator.Extensions;

using FluentAssertions;

using Xunit;

namespace ChequeCreatorTests.Extensions
{
    public class NumericExtensionsTests
    {
        [Theory]
        [InlineData(1000, "one thousand dollars")]
        [InlineData(3005000150.65, "three billion five million one hundred and fifty dollars and sixty-five cents")]
        [InlineData(00.00, "zero dollars")]
        [InlineData(-123.55, "minus one hundred and twenty-three dollars and fifty-five cents")]
        [InlineData(100.00, "one hundred dollars")]
        public void ToEnglishWords_WithNullModel_ReturnsNull(double source, string expected)
        {
            var result = NumericExtensions.ToEnglishWords(source);
            result.Should().Match(x => x.Equals(expected, StringComparison.OrdinalIgnoreCase));
        }
    }
}
