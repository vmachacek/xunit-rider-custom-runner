using Xunit.Abstractions;

namespace TestProject2;

public class MyRunnerReporter : IRunnerReporter
{
    public string Description => "My custom runner reporter";

    // Hard-coding `true` means this reporter will always be enabled.
    //
    // You can also implement logic to conditional enable/disable the reporter.
    // Most reporters based this decision on an environment variable.
    // Eg: https://github.com/xunit/xunit/blob/cbf28f6d911747fc2bcd64b6f57663aecac91a4c/src/xunit.runner.reporters/TeamCityReporter.cs#L11
    public bool IsEnvironmentallyEnabled => true;

    public string RunnerSwitch => null;

    public IMessageSink CreateMessageHandler(IRunnerLogger logger)
    {
        throw new Exception("CreateMessageHandler");
        return new MyMessageSink();
    }
}