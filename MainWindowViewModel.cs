using System.Collections.ObjectModel;

namespace MahAppsBugDemo;

internal class MainWindowViewModel {

    public List<TestValue> Values { get; } = new() { new FirstTestValue(), new SecondTestValue() };

}

public class FirstTestValue : TestValue {

}

public class SecondTestValue : TestValue {

}

public class TestValue {

    public string Value { get; init; } = "value";

    public ObservableCollection<char> SelectedChars { get; } = new();

}

