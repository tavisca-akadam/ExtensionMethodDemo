using ExtensionMethodDemo.src;
using System;
using Xunit;

namespace LagacyExtensionsTests
{
    public class LagacyExtensionFixture
    {
        [Fact]
        public void Lagacy_extension_should_return_date_time_in_string_format_year_less_than_1930()
        {
            var dateTime = new DateTime(1930, 12, 31);
            Assert.Equal("0301231", dateTime.ToLagacyFormat());
        }
        [Fact]
        public void Lagacy_extension_should_return_date_time_in_string_format_year_greater_than_1930()
        {
            var dateTime = new DateTime(2010, 12, 31);
            Assert.Equal("1101231", dateTime.ToLagacyFormat());
        }

        [Fact]
        public void Lagacy_extension_should_return_name_in_uppercase_splited_format()
        {
            var name = "anil kadam";
            Assert.Equal("KADAM, ANIL", name.ToLagacyFormat());
        }
    }
}
