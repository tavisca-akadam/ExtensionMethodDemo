using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LagacyExtensionsTests
{
    public class DateTimeExtensionsFixture
    {
        [Fact]
        public void XmlDateTime_should_return_dateTime_in_year_month_date_seperated_by_dashes()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 35, 951);
            Assert.Equal("2013-10-24T13:10:35.951Z", dateTime.ToXmlDateTime());
        }

        [Fact]
        public void XmlDateTime_should_return_dateTime_in_year_month_date_seperated_by_dashes_with_specifying_localization_format()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 35, 951);
            Assert.Equal("2013-10-24T13:10:35.951+05:30", dateTime.ToXmlDateTime(System.Xml.XmlDateTimeSerializationMode.Local));
        }
    }
}
