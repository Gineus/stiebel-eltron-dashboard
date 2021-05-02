using AutoFixture;
using AutoMoqCore;
using Moq;
using StiebelEltronApiServer.Models;
using StiebelEltronApiServer.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StiebelEltronApiServerTests
{
    public class StatisticsServiceTests
    {
        [Theory]
        [MemberData(nameof(StatisticsServiceTestDailyPeriodDataGenerator.GetHeatPumpTestData), MemberType = typeof(StatisticsServiceTestDailyPeriodDataGenerator))]
        public void WhenScrapingServiceWeltTotalPowerConsumptionIsReturned(IEnumerable<HeatPumpDatum> heatPumpData, HeatPumpDataPerPeriod expectedHeatPumpDataPerPeriod)
        {
            var autoMoqer = new AutoMoqer();
            var fixture = new Fixture();
            var sessionId = fixture.Create<string>();
            var now = heatPumpData.Select(h => h.DateCreated).Min();

            var statisticsService = autoMoqer.Create<StatisticsService>();
            var year = heatPumpData.FirstOrDefault().DateCreated.Year;

            // Act
            var calculatedHeatPumpDataPerPeriod = statisticsService.GetHeatPumpDataPerPeriod(heatPumpData, year, "Day", 13, now);

            // Assert
            Assert.Equal(expectedHeatPumpDataPerPeriod, calculatedHeatPumpDataPerPeriod);
        }
    }
}
