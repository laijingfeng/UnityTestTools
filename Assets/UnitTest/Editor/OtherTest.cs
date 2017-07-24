using System.Threading;
using NUnit.Framework;

public class OtherTest
{
    [Test]
    [MaxTime(100)]
    public void SlowTest()
    {
        Thread.Sleep(200);
    }
}