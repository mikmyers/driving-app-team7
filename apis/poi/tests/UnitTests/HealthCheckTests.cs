using System;
using Xunit;
using poi.Models;

namespace UnitTests
{
    public class HealthCheckUnitTests
    {
        [Fact]
        public void HealthCheckTestModel()
        {
            Assert.Equal("POI Service Healthcheck", new Healthcheck().Message);
            Assert.Equal("Broken", new Healthcheck().Status);
            Assert.Equal("Healthy", new Healthcheck().Status);

        }
    }
}
