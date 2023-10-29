namespace Brimborium.LogicClock.Test;

public class LogicalTimestampTest {
    [Fact]
    public void LogicalTimestampTest01() {
        var act = new LogicalTimestamp(1);
        Assert.Equal(1, act.Ticks);
        Assert.Equal(1, act.Value);
        Assert.Equal("1", act.ToString());
    }

    [Fact]
    public void LogicalTimestampTest02() {
        {
            var a = new LogicalTimestamp(1);
            var b = new LogicalTimestamp(2);
            var act = a + b;
            Assert.Equal(2, act.Ticks);
        }
        {
            var a = new LogicalTimestamp(2);
            var b = new LogicalTimestamp(1);
            var act = a + b;
            Assert.Equal(2, act.Ticks);
        }
    }

    [Fact]
    public void LogicalTimestampTest03() {
        {
            var a = new LogicalTimestamp(1, "a");
            var b = new LogicalTimestamp(2, "b");
            var act = a * b;
            Assert.Equal(3, act.Ticks);
            Assert.Equal("b", act.Name);
        }
        {
            var a = new LogicalTimestamp(2, "a");
            var b = new LogicalTimestamp(1, "b");
            var act = a * b;
            Assert.Equal(3, act.Ticks);
            Assert.Equal("a", act.Name);
        }
    }

    [Fact]
    public void LogicalTimestampTest04() {
        {
            var a = new LogicalTimestamp(1, "a");
            var b = a++;
            Assert.Equal(1, b.Ticks);
            Assert.Equal(2, a.Ticks);
        }
        {
            var a = new LogicalTimestamp(1, "a");
            var b = ++a;
            Assert.Equal(2, b.Ticks);
            Assert.Equal(2, a.Ticks);
        }
    }

    [Fact]
    public void LogicalTimestampTest05() { }

    [Fact]
    public void LogicalTimestampTest06() { }

    [Fact]
    public void LogicalTimestampTest07() { }

    [Fact]
    public void LogicalTimestampTest08() { }
}
