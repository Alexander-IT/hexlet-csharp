using Humanizer;

namespace Hexlet;

public static class Greeting
{
    public static string GetMessage() => "hexlet".Transform(To.TitleCase);
}