// Here you could define global logic that would affect all tests

// You can use attributes at the assembly level to apply to all tests in the assembly
[assembly: Retry(3)]
[assembly: System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]

namespace TunitTestRunner;

public class GlobalHooks
{
    [Before(TestDiscovery)]
    public static void BeforeDiscovery()
    {
        Console.WriteLine("BeforeDiscovery");
        // Console.WriteLine($"Loading assembly {typeof(TunitTests1.Tests).Assembly}");
        // Console.WriteLine($"Loading assembly {typeof(TunitTests2.Tests).Assembly}");
    }
    
    [Before(TestSession)]
    public static void SetUp()
    {
        Console.WriteLine("Or you can define methods that do stuff before...");
    }

    [After(TestSession)]
    public static void CleanUp()
    {
        Console.WriteLine("...and after!");
    }
}