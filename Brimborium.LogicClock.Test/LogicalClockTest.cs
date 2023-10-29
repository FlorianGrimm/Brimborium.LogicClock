namespace Brimborium.LogicClock.Test;

public class LogicalClockTest {
    [Fact]
    public void LogicalClockTest1() {
        var sut = new LogicalClock();
        var a = sut.GetTimestamp("A");
        var b = sut.GetTimestamp("B");
        a++;
    }
}