using System.Reflection;

namespace HelloDotNet;

public static class AsciiArt
{
  public static void Write(RenderOptions o)
  {
    FiggleFont? font = null;
    if (!string.IsNullOrWhiteSpace(o.Font))
    {
      font = typeof(FiggleFonts)
        .GetProperty(o.Font,
          BindingFlags.Static | BindingFlags.Public)
        ?.GetValue(null)
        as FiggleFont;
      if (font == null)
      {
        WriteLine($"Could not find font '{o.Font}'");
      }
    }

    font ??= FiggleFonts.Standard;

    if (o?.Text != null)
    {
      Console.WriteLine(font.Render(o.Text));
      Console.WriteLine("Brought to you by " + typeof(AsciiArt).FullName);
    }
  }
}