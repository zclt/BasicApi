using System.Collections.Generic;
using System.Globalization;
using Basic.Common;
using FluentAssertions;
using Xunit;

namespace BasicApi.Test
{
    public class DecimalExtensionsTest
    {
        [Fact]
        public void ToDecimalPtBrTest()
        {
            //arrange
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
            
            //act
            //assert
            "1 000".ToDecimal().Should().Be(0m);
            "1.000".ToDecimal().Should().Be(1000m);
            "1,000".ToDecimal().Should().Be(1.000m);
            "1.000,00".ToDecimal().Should().Be(1000.00m);
            "1.000.00".ToDecimal().Should().Be(100000m);
            "1,000.00".ToDecimal().Should().Be(0m);
        }
        
        [Fact]
        public void ToDecimalEnUsTest()
        {
            //arrange
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            
            //act
            //assert
            "1 000".ToDecimal().Should().Be(0m);
            "1.000".ToDecimal().Should().Be(1.000m);
            "1,000".ToDecimal().Should().Be(1000m);
            "1.000,00".ToDecimal().Should().Be(0m);
            "1.000.00".ToDecimal().Should().Be(0m);
            "1,000.00".ToDecimal().Should().Be(1000.00m);
        }
    }
}