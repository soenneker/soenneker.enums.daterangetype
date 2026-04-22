using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.DateRangeType.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DateRangeTypeTests : HostedUnitTest
{
    public DateRangeTypeTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
