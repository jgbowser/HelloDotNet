using System.Reflection;

namespace HelloDotNet;

public static class FontList
{
  public static void Write(FontListOptions o)
  {
    // get a list of the fonts availale in the FiggleFonts class
    var fonts = typeof(FiggleFonts)
    .GetProperties(BindingFlags.Static | BindingFlags.Public)
    .Select(p => p.Name)
    .ToList();

    WriteLine("Available fonts:");
    foreach (var font in fonts)
    {
      WriteLine(font);
    }
  }
}