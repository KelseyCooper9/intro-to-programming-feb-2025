using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.BusinessClock;
public class BusinessClockTests
{
    [Fact]
    public void ReturnsClosedOnSaturdays()
    {
        var clock = new BusinessClockProvider();
        Assert.False(clock.WeAreCurrentlyDuringBusinessHours());
    }
    [Fact]  
    public void ReturnsOpenOnMondays() {
        var clock = new BusinessClockProvider();
        Assert.True(clock.WeAreCurrentlyDuringBusinessHours());
    }
}
