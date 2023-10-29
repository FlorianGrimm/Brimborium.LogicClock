namespace Brimborium.LogicClock;

using System.Collections.Concurrent;

public class LogicalClock {
    private readonly ConcurrentDictionary<string, LogicalTimestamp> _Timestamps;

    public LogicalClock() {
        this._Timestamps = new ConcurrentDictionary<string, LogicalTimestamp>();
    }

    public LogicalTimestamp GetTimestamp(string name)
        => (this._Timestamps.TryGetValue(name, out var result))
        ? result
        : this._Timestamps.GetOrAdd(
            key: name,
            valueFactory: (name) => new LogicalTimestamp(1, name));

    public LogicalTimestamp SetTimestamp(string name, LogicalTimestamp value)
        => this._Timestamps.AddOrUpdate(
            key: name,
            addValue: value,
            updateValueFactory: (name, oldValue) => {
                if (oldValue.Ticks < value.Ticks) {
                    return new LogicalTimestamp(value.Ticks, name);
                } else {
                    return new LogicalTimestamp(oldValue.Ticks, name);
                }
            });
}
